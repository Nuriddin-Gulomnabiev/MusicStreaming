using AutoMapper;
using Client.Application.Common.Interfaces;
using Services.Services.IdentifiedService;

namespace Client.Application.Common.Handlers
{
    internal class BaseCommandQueryHandler
    {
        internal readonly IClientApplicationDbContext dbContext;
        internal readonly IIdentifiedService identifiedService;
        internal readonly IMapper mapper;

        public BaseCommandQueryHandler(
            IClientApplicationDbContext dbContext,
            IMapper mapper,
            IIdentifiedService identifiedService
            )
        {
            this.identifiedService = identifiedService;
            this.dbContext = dbContext;
            this.mapper = mapper;
        }
    }
}
