using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Entities.Playlists;
using MediatR;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Command.CreatePlaylist
{
    internal class CreatePlaylistHandler : BaseCommandQueryHandler, IRequestHandler<CreatePlaylistCommand>
    {
        public CreatePlaylistHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(CreatePlaylistCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            dbContext.Playlists.Add(new Playlist()
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                IsActive = true,
                LastUpdatedAt = DateTime.Now,
                CreatedByArtistId = userId,
            });

            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
