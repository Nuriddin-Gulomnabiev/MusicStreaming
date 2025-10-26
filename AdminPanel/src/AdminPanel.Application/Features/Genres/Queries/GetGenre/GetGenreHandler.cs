using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Genres.Queries.GetGenre
{
    internal class GetGenreHandler : BaseCommandQueryHandler, IRequestHandler<GetGenreQuery, GetGenreViewModel>
    {
        public GetGenreHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<GetGenreViewModel> Handle(GetGenreQuery request, CancellationToken cancellationToken)
        {
            return await dbContext.Genres
                .Where(g => g.Code == request.Code)
                .ProjectTo<GetGenreViewModel>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(cancellationToken)
                ?? throw new ResourceNotFoundException("Жанр не найден");
        }
    }
}
