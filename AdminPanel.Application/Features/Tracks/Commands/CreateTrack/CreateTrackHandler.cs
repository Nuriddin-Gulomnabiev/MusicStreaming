using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using Domain.Entities.Tracks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.FileManager;

namespace AdminPanel.Application.Features.Tracks.Commands.CreateTrack
{
    internal class CreateTrackHandler : BaseCommandQueryHandler, IRequestHandler<CreateTrackCommand>
    {
        private readonly IFileManagerService fileManagerService;

        public CreateTrackHandler(IAdminApplicationDbContext dbContext, IMapper mapper, IFileManagerService fileManagerService) : base(dbContext, mapper)
        {
            this.fileManagerService = fileManagerService;
        }

        public async Task<Unit> Handle(CreateTrackCommand request, CancellationToken cancellationToken)
        {
            var album = await dbContext.Albums.Where(a => a.Code == request.AlbumCode).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            var artists = await GetArtists(request.ArtistsCodes);

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var track = new Track()
                {
                    Id = Guid.NewGuid(),
                    Name = request.Name,
                    AlbumId = album.Id,
                    IsActive = true
                };

                var artistsTracks = artists.Select(a =>
                    new ArtistTrack
                    {
                        Id = Guid.NewGuid(),
                        TrackId = track.Id,
                        ArtistId = a.Id
                    }
                );

                dbContext.Tracks.Add(track);
                dbContext.ArtistTracks.AddRange(artistsTracks);

                var result = await fileManagerService.CreateTrack(request.Track, track.Id);

                await dbContext.SaveChangesAsync();
                tran.Commit();

                return Unit.Value;
            }
            catch (Exception)
            {
                tran.Rollback();

                throw;
            }
        }

        private async Task<List<Artist>> GetArtists(List<int> artistsCode)
        {
            var artistsCodes = artistsCode.Distinct();
            var artists = new List<Artist>();

            foreach (var artistCode in artistsCodes)
            {
                var artist = await dbContext.Artists.Where(a => a.Code == artistCode).FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Исполнитель не найден");

                artists.Add(artist);
            }

            return artists;
        }
    }
}
