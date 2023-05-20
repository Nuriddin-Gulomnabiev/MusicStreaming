using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Command.DeletePlaylist
{
    internal class DeletePlaylistHandler : BaseHandler, IRequestHandler<DeletePlaylistCommand>
    {
        public DeletePlaylistHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(DeletePlaylistCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists.Where(p => p.CreatedByArtistId == userId && p.Code == request.PlaylistCode && p.IsActive).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            playlist.LastUpdatedAt = DateTime.Now;
            playlist.IsActive = false;

            dbContext.Attach(playlist);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
