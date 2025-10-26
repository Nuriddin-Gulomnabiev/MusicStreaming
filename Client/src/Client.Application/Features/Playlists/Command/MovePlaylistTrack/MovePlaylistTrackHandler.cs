using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Command.MovePlaylistTrack
{
    internal class MovePlaylistTrackHandler : BaseHandler, IRequestHandler<MovePlaylistTrackCommand>
    {
        public MovePlaylistTrackHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(MovePlaylistTrackCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists.Where(p => p.Code == request.PlaylistCode && p.CreatedByArtistId == userId).AsNoTracking().FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            var tracksCount = await dbContext.PlaylistTracks.Where(p => p.PlaylistId == playlist.Id).AsNoTracking().CountAsync();

            if (request.FromPosition > tracksCount || request.ToPosition > tracksCount ||
                request.FromPosition < 0 || request.ToPosition < 0)
            {
                throw new ResourceNotFoundException("Позиция не найдена");
            }

            int secondPosition = request.FromPosition > request.ToPosition
                ? request.ToPosition - 1
                : request.ToPosition + 1;

            var firstTracksPosition = await dbContext.PlaylistTracks
                .Where(p => p.PlaylistId == playlist.Id)
                .OrderBy(o => o.Position)
                .Skip(request.ToPosition - 1)
                .Select(t => t.Position)
                .FirstOrDefaultAsync();

            decimal secondTrackPosition = 0;

            if (secondPosition > tracksCount)
            {
                secondTrackPosition = firstTracksPosition + 50;
            }
            else if (secondPosition > 0)
            {
                secondTrackPosition = await dbContext.PlaylistTracks
                    .Where(p => p.PlaylistId == playlist.Id)
                    .OrderBy(o => o.Position)
                    .Skip(secondPosition - 1)
                    .Select(t => t.Position)
                    .FirstOrDefaultAsync();
            }

            decimal newPosition = (firstTracksPosition + secondTrackPosition) / 2;

            var movedTrack = await dbContext.PlaylistTracks
                    .Where(p => p.PlaylistId == playlist.Id)
                    .OrderBy(o => o.Position)
                    .Skip(request.FromPosition - 1)
                    .FirstOrDefaultAsync();

            dbContext.Attach(movedTrack);

            movedTrack.Position = newPosition;

            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
