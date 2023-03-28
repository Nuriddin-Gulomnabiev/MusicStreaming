using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Helpers;
using Client.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Identity.Commands.Logout
{
    internal class LogoutHandler : BaseCommandQueryHandler, IRequestHandler<LogoutCommand>
    {
        public LogoutHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var payload = identifiedService.GetPayload<JwtPayload>();

            var session = await dbContext.Sessions.Where(s => s.ArtistId == userId && s.DeviceId == payload.DeviceId).FirstOrDefaultAsync();

            if (session == null)
                return Unit.Value;

            dbContext.Sessions.Remove(session);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
