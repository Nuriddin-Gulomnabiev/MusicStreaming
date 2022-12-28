using Domain.Exceptions;
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
            var artist = await dbContext.Artists
                .Where(a => a.Code == request.Code)
                .Include(a => a.ArtistAlbums)
                .ThenInclude(aa => aa.Album)
                .FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Исполнитель не найден");

            return mapper.Map<GetArtistViewModel>(artist);
        }
    }
}
