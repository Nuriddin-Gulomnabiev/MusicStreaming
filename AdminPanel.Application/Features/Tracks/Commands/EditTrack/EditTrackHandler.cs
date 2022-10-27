using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using Domain.Entities.Tracks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.FileManager;

namespace AdminPanel.Application.Features.Tracks.Commands.EditTrack
{
    internal class EditTrackHandler : BaseCommandQueryHandler, IRequestHandler<EditTrackCommand, bool>
    {
        private readonly IFileManagerService fileManagerService;

        public EditTrackHandler(IAdminApplicationDbContext dbContext, IMapper mapper, IFileManagerService fileManagerService) : base(dbContext, mapper)
        {
            this.fileManagerService = fileManagerService;
        }

        public async Task<bool> Handle(EditTrackCommand request, CancellationToken cancellationToken)
        {
            var track = await dbContext.Tracks
                    .Where(t => t.Id == request.Id && t.Code == request.Code)
                    .Include(t => t.Album)
                    .FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Трек не найден");

            using (var tran = dbContext.Database.BeginTransaction())
            {
                try
                {
                    if (request.AlbumCode != track.Album.Code)
                        await UpdateAlbumTrack(request, track);

                    await UpdateTrackArtists(request, track);

                    track.Name = request.Name;
                    track.IsActive = request.IsActive;

                    dbContext.Tracks.Update(track);
                    await dbContext.SaveChangesAsync();

                    if (request.IsTrackReloaded)
                        await UpdateTrackFile(request, track);

                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();

                    throw;
                }
            }

            return true;
        }

        private async Task UpdateTrackFile(EditTrackCommand request, Track track)
        {
            var res = await fileManagerService.CreateTrack(request.Track, track.Id);
        }

        private async Task UpdateTrackArtists(EditTrackCommand request, Track track)
        {
            var oldArtists = await dbContext.ArtistTracks
                    .Where(a => a.TrackId == track.Id)
                    .Include(a => a.Artist)
                    .ToListAsync();

            var newArtistCodes = request.ArtistsCodes.Distinct().ToList();

            foreach (var oldArtist in oldArtists)
            {
                if (newArtistCodes.Contains(oldArtist.Artist.Code))
                    newArtistCodes.Remove(oldArtist.Artist.Code);
                else
                    dbContext.ArtistTracks.Remove(oldArtist);
            }

            foreach (var newArtistCode in newArtistCodes)
            {
                var newArtist = await dbContext.Artists
                    .Where(a => a.Code == newArtistCode)
                    .AsNoTracking()
                    .FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Исполнитель не найден");

                dbContext.ArtistTracks.Add(new ArtistTrack()
                {
                    Id = Guid.NewGuid(),
                    ArtistId = newArtist.Id,
                    TrackId = track.Id
                });
            }
        }

        private async Task UpdateAlbumTrack(EditTrackCommand request, Track track)
        {
            var newAlbum = await dbContext.Albums.Where(a => a.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            track.Album = newAlbum;
            track.AlbumId = newAlbum.Id;
        }
    }
}
