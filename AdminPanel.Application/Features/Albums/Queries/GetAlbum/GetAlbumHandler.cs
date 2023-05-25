using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    internal class GetAlbumHandler : BaseCommandQueryHandler, IRequestHandler<GetAlbumQuery, GetAlbumViewModel>
    {
        public GetAlbumHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<GetAlbumViewModel> Handle(GetAlbumQuery request, CancellationToken cancellationToken)
        {
            return await dbContext.Albums.Where(a => a.Code == request.Code)
                                         .Include(a => a.Tracks)
                                         .Include(a => a.AlbumGenres)
                                         .ThenInclude(ag => ag.Genre)
                                         .Include(a => a.ArtistAlbums)
                                         .ThenInclude(aa => aa.Artist)
                                         .ProjectTo<GetAlbumViewModel>(mapper.ConfigurationProvider)
                                         .FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");
        }
    }
}
