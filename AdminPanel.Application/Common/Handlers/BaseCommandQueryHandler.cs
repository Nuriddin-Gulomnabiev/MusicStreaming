using AdminPanel.Application.Common.Interfaces;
using AutoMapper;

namespace AdminPanel.Application.Common.Handlers
{
    internal class BaseCommandQueryHandler
    {
        internal readonly IAdminApplicationDbContext dbContext;
        internal readonly IMapper mapper;

        public BaseCommandQueryHandler(IAdminApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
    }
}
