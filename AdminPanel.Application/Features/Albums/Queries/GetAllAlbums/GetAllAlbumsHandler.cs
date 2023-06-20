using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Albums.Queries.GetAllAlbums
{
    internal class GetAllAlbumsHandler : BaseCommandQueryHandler, IRequestHandler<GetAllAlbumsQuery, List<GetAllAlbumsViewModel>>
    {
        public GetAllAlbumsHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<List<GetAllAlbumsViewModel>> Handle(GetAllAlbumsQuery request, CancellationToken cancellationToken)
        {
            var skipCount = (request.Page - 1) * request.PageSize;

            var albumsQuery = dbContext.Albums
                .Include(t => t.ArtistAlbums)
                .ThenInclude(at => at.Artist)
                .AsQueryable();

            if (request.Artists != null && request.Artists.Any())
            {
                albumsQuery = albumsQuery.Where(a => a.ArtistAlbums.Where(at => request.Artists.Contains(at.Artist.Code)).Any());
            }

            if (!string.IsNullOrEmpty(request.Name))
            {
                albumsQuery = albumsQuery.Where(a => a.Name.ToLower().Contains(request.Name.ToLower()));
            }

            var albums = await albumsQuery
                .Skip(skipCount)
                .Take(request.PageSize)
                .OrderBy(t => t.Name)
                .ToListAsync(cancellationToken);

            var result = mapper.Map<List<GetAllAlbumsViewModel>>(albums);

            return result;
        }
    }
}
