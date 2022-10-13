using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Artists.Queries.GetArtist
{
    internal class GetArtistHandler : BaseCommandQueryHandler, IRequestHandler<GetArtistQuery, GetArtistViewModel>
    {
        public GetArtistHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<GetArtistViewModel> Handle(GetArtistQuery request, CancellationToken cancellationToken)
        {
            int artistCode = request.Code;

            var artist = await dbContext.Artists.Where(a => a.Code == artistCode).FirstOrDefaultAsync()
                ?? throw new ArtistNotFoundException();

            var artistViewModel = mapper.Map<GetArtistViewModel>(artist);

            var albums = await dbContext.ArtistAlbums.Where(a => a.ArtistId == artist.Id).Select(a => a.Album).ToListAsync();

            if (albums.Any())
                artistViewModel.Albums = albums.ToDictionary(a => a.Code, a => a.Name);

            return artistViewModel;
        }
    }
}
