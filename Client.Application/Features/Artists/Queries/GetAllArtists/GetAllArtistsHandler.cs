using AutoMapper;
using AutoMapper.QueryableExtensions;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Artists.Queries.GetAllArtists
{
    internal class GetAllArtistsHandler : BaseHandler, IRequestHandler<GetAllArtistsQuery, List<GetAllArtistsViewModel>>
    {
        public GetAllArtistsHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<List<GetAllArtistsViewModel>> Handle(GetAllArtistsQuery request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            return await dbContext.Artists.Where(a => a.IsActive && a.Id != userId)
                .AsNoTracking()
                .ProjectTo<GetAllArtistsViewModel>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
