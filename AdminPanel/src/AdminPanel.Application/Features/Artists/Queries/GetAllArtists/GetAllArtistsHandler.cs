using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Artists.Queries.GetAllArtists
{
    internal class GetAllArtistsHandler : BaseCommandQueryHandler, IRequestHandler<GetAllArtistsQuery, IEnumerable<GetAllArtistsViewModel>>
    {
        public GetAllArtistsHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<GetAllArtistsViewModel>> Handle(GetAllArtistsQuery request, CancellationToken cancellationToken)
        {
            var artists = await dbContext.Artists
                .OrderBy(a => a.Name)
                .Include(a => a.ArtistAlbums)
                .ThenInclude(aa => aa.Album)
                .ToListAsync();

            return mapper.Map<List<GetAllArtistsViewModel>>(artists);
        }
    }
}
