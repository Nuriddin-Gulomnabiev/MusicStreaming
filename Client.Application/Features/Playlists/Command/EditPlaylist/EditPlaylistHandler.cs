using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Command.EditPlaylist
{
    internal class EditPlaylistHandler : BaseCommandQueryHandler, IRequestHandler<EditPlaylistCommand>
    {
        public EditPlaylistHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(EditPlaylistCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists.Where(p => p.CreatedByArtistId == userId && p.Code == request.PlaylistCode && p.IsActive).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            if (request.Title != null && !playlist.Title.Equals(request.Title))
            {
                playlist.Title = request.Title;
            }

            if (request.IsPublic.HasValue && !playlist.IsPublic.Equals(request.IsPublic))
            {
                playlist.IsPublic = request.IsPublic.Value;
            }

            await dbContext.UpdateChangedProperties(playlist);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
