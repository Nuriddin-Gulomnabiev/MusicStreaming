using Domain.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
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
            var genre = await dbContext.Genres.Where(g => g.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Жанр не найден");

            return mapper.Map<GetGenreViewModel>(genre);
        }
    }
}
