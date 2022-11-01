using Domain.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using Domain.Entities.Tracks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Services.Services.FileManager;

namespace AdminPanel.Application.Features.Tracks.Commands.EditTrack
{
    internal class EditTrackHandler : BaseCommandQueryHandler, IRequestHandler<EditTrackCommand>
    {
        private readonly IFileManagerService fileManagerService;

        public EditTrackHandler(IAdminApplicationDbContext dbContext, IMapper mapper, IFileManagerService fileManagerService) : base(dbContext, mapper)
        {
            this.fileManagerService = fileManagerService;
        }

        public async Task<Unit> Handle(EditTrackCommand request, CancellationToken cancellationToken)
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
                        await UpdateAlbumTrack(request.AlbumCode, track);

                    await UpdateTrackArtists(request.ArtistsCodes, track);

                    track.Name = request.Name;
                    track.IsActive = request.IsActive;

                    dbContext.Tracks.Update(track);
                    await dbContext.SaveChangesAsync();

                    if (request.IsTrackReloaded)
                        await UpdateTrackFile(request.Track, track.Id);

                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();

                    throw;
                }
            }

            return Unit.Value;
        }

        private async Task UpdateTrackFile(IFormFile file, Guid trackId)
        {
            var res = await fileManagerService.CreateTrack(file, trackId);
        }

        private async Task UpdateTrackArtists(IEnumerable<int> artistsCodes, Track track)
        {
            var oldArtists = await dbContext.ArtistTracks
                    .Where(a => a.TrackId == track.Id)
                    .Include(a => a.Artist)
                    .ToListAsync();

            var newArtistCodes = artistsCodes.Distinct().ToList();

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

        private async Task UpdateAlbumTrack(int albumCode, Track track)
        {
            var newAlbum = await dbContext.Albums.Where(a => a.Code == albumCode).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            track.Album = newAlbum;
            track.AlbumId = newAlbum.Id;
        }
    }
}
