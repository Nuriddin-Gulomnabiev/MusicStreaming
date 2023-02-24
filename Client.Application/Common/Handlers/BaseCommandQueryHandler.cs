using AutoMapper;
using Client.Application.Common.Interfaces;

namespace Client.Application.Common.Handlers
{
    internal class BaseCommandQueryHandler
    {
        internal readonly IClientApplicationDbContext dbContext;
        internal readonly IMapper mapper;

        public BaseCommandQueryHandler(IClientApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
    }
}
