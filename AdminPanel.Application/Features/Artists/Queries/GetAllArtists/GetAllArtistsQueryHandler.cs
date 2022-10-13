using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Artists.Queries.GetAllArtists
{
    internal class GetAllArtistsQueryHandler : BaseCommandQueryHandler, IRequestHandler<GetAllArtistsQuery, IEnumerable<GetAllArtistsViewModel>>
    {
        public GetAllArtistsQueryHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<IEnumerable<GetAllArtistsViewModel>> Handle(GetAllArtistsQuery request, CancellationToken cancellationToken)
        {
            var artists = await dbContext.Artists.OrderBy(a => a.Name).ToListAsync();

            var result = new List<GetAllArtistsViewModel>();

            foreach (Domain.Entities.Artists.Artist artist in artists)
            {
                var albums = await dbContext.ArtistAlbums.Where(a => a.ArtistId == artist.Id).Select(a => a.Album).ToListAsync(cancellationToken: cancellationToken);

                var artistVM = mapper.Map<GetAllArtistsViewModel>(artist);

                if (albums.Any())
                    artistVM.Albums = albums.ToDictionary(a => a.Code, a => a.Name);

                result.Add(artistVM);
            }

            return result;
        }
    }
}
