using AutoMapper;
using AutoMapper.QueryableExtensions;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Query.GetMyPlaylists
{
    internal class GetMyPlaylistsHandler : BaseHandler, IRequestHandler<GetMyPlaylistsQuery, List<GetMyPlaylistsViewModel>>
    {
        public GetMyPlaylistsHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<List<GetMyPlaylistsViewModel>> Handle(GetMyPlaylistsQuery request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            return await dbContext.Playlists
                .Where(p => p.CreatedByArtistId == userId && p.IsActive)
                .ProjectTo<GetMyPlaylistsViewModel>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
