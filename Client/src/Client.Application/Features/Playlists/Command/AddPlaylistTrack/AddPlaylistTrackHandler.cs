using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Entities.Playlists;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Command.AddPlaylistTrack
{
    internal class AddPlaylistTrackHandler : BaseHandler, IRequestHandler<AddPlaylistTrackCommand>
    {
        public AddPlaylistTrackHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(AddPlaylistTrackCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists.Where(p => p.Code == request.PlaylistCode && p.CreatedByArtistId == userId).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            var track = await dbContext.Tracks.Where(t => t.Code == request.TrackCode && t.IsActive).AsNoTracking().FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Трек не найден");

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var lastTrackPosition = await dbContext.PlaylistTracks.Where(p => p.PlaylistId == playlist.Id).MaxAsync(p => p.Position);

                var playlistTrack = new PlaylistTrack()
                {
                    Id = Guid.NewGuid(),
                    TrackId = track.Id,
                    PlaylistId = playlist.Id,
                    Position = lastTrackPosition + 50
                };

                dbContext.PlaylistTracks.Add(playlistTrack);
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
    }
}
