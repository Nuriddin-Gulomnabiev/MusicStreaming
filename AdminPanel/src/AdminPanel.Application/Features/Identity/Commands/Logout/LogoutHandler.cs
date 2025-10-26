using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;
using Services.Services.JwtService.Exceptions;

namespace AdminPanel.Application.Features.Identity.Commands.Logout
{
    internal class LogoutHandler : BaseCommandQueryHandler, IRequestHandler<LogoutCommand>
    {
        private readonly IIdentifiedService identifiedService;

        public LogoutHandler(
            IMapper mapper,
            IAdminApplicationDbContext dbContext,
            IIdentifiedService identifiedService
            ) : base(dbContext, mapper)
        {
            this.identifiedService = identifiedService;
        }

        public async Task<Unit> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();
            var token = identifiedService.GetToken();

            var admin = await dbContext.Admins
                .Where(a => a.Id == userId && a.AccessToken == token)
                .FirstOrDefaultAsync()
                ?? throw new TokenExpiredException();



            return Unit.Value;
        }
    }
}
