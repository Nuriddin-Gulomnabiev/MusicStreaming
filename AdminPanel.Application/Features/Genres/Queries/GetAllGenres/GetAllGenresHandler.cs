using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Genres.Queries.GetAllGenres
{
    internal class GetAllGenresHandler : BaseCommandQueryHandler, IRequestHandler<GetAllGenresQuery, List<GetAllGenresViewModel>>
    {
        public GetAllGenresHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<List<GetAllGenresViewModel>> Handle(GetAllGenresQuery request, CancellationToken cancellationToken)
        {
            var genres = dbContext.Genres.AsQueryable();

            if (!string.IsNullOrEmpty(request.Name))
            {
                genres = genres.Where(g => g.Name.ToLower().Contains(request.Name.ToLower()));
            }

            var skipCount = (request.Page - 1) * request.PageSize;

            return await genres
                .Skip(skipCount)
                .Take(request.PageSize)
                .ProjectTo<GetAllGenresViewModel>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
