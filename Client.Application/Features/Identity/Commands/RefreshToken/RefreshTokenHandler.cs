using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Helpers;
using Client.Application.Common.Interfaces;
using Services.Services.JwtService.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;
using Services.Services.JwtService;

namespace Client.Application.Features.Identity.Commands.RefreshToken
{
    internal class RefreshTokenHandler : BaseCommandQueryHandler, IRequestHandler<RefreshTokenCommand, RefreshTokenViewModel>
    {
        private readonly IIdentifiedService identifiedService;
        private readonly IJwtService jwtService;

        public RefreshTokenHandler(
            IClientApplicationDbContext dbContext,
            IMapper mapper,
            IIdentifiedService identifiedService,
            IJwtService jwtService
            ) : base(dbContext, mapper)
        {
            this.jwtService = jwtService;
            this.identifiedService = identifiedService;
        }

        public async Task<RefreshTokenViewModel> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();
            var payload = identifiedService.GetPayload<JwtPayload>();
            var refreshToken = identifiedService.GetToken();

            var session = await dbContext.Sessions
                .Where(s => s.ArtistId == userId &&
                            s.DeviceId == payload.DeviceId &&
                            s.RefreshToken == refreshToken)
                .FirstOrDefaultAsync()
                ?? throw new TokenExpiredException();

            var tokens = jwtService.CreateToken(payload);

            session.RefreshToken = tokens.RefreshToken;
            session.ExpiresAt = tokens.RefreshExpiresAt;

            dbContext.Sessions.Update(session);
            await dbContext.SaveChangesAsync();

            return new RefreshTokenViewModel() { AccessToken = tokens.AccessToken, RefreshToken = tokens.RefreshToken };
        }
    }
}
