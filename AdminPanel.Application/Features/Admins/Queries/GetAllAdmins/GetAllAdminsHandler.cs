using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper.QueryableExtensions;

namespace AdminPanel.Application.Features.Admins.Queries.GetAllAdmins
{
    internal class GetAllAdminsHandler : BaseCommandQueryHandler, IRequestHandler<GetAllAdminsQuery, List<GetAllAdminsViewModel>>
    {
        public GetAllAdminsHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<List<GetAllAdminsViewModel>> Handle(GetAllAdminsQuery request, CancellationToken cancellationToken)
        {
            var admins = await dbContext.Admins
                .AsNoTracking()
                .ProjectTo<GetAllAdminsViewModel>(mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return admins;
        }
    }
}
