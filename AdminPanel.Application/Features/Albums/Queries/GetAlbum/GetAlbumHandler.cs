using Domain.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
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
            var album = await dbContext.Albums.Where(a => a.Code == request.Code)
                                        .Include(a => a.Tracks)
                                        .FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            var artists = await dbContext.ArtistAlbums.Where(a => a.AlbumId == album.Id)
                                                      .Select(a => a.Artist)
                                                      .ToListAsync()
                ?? throw new ResourceNotFoundException($"Исполнители альбома {album.Code} не найдены");

            var genres = await dbContext.AlbumGenres.Where(a => a.AlbumId == album.Id)
                                                    .Select(a => a.Genre)
                                                    .ToListAsync()
                ?? throw new ResourceNotFoundException($"Жанры альбома {album.Code} не найдены");

            var albumViewModel = mapper.Map<GetAlbumViewModel>(album);

            albumViewModel.Artists = artists.ToDictionary(a => a.Code, a => a.Name);
            albumViewModel.Genres = genres.ToDictionary(a => a.Code, a => a.Name);

            return albumViewModel;
        }
    }
}
