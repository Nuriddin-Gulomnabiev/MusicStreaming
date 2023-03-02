using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using Services.Services.IdentifiedService;
using Services.Services.JwtService;
using Services.Services.JwtService.Exceptions;
using AdminPanel.Application.Common.Helpers;

namespace AdminPanel.Application.Features.Identity.Commands.RefreshToken
{
    internal class RefreshTokenHandler : BaseCommandQueryHandler, IRequestHandler<RefreshTokenCommand, RefreshTokenViewModel>
    {
        private readonly IJwtService jwtService;
        private readonly IIdentifiedService identifiedService;

        public RefreshTokenHandler(
            IMapper mapper,
            IJwtService jwtService,
            IIdentifiedService identifiedService,
            IAdminApplicationDbContext dbContext
        ) : base(dbContext, mapper)
        {
            this.jwtService = jwtService;
            this.identifiedService = identifiedService;
        }

        public async Task<RefreshTokenViewModel> Handle(RefreshTokenCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();
            var refreshToken = identifiedService.GetToken();

            var admin = await dbContext.Admins.Where(a => a.RefreshToken == refreshToken && a.Id == userId).FirstOrDefaultAsync()
                ?? throw new TokenInvalidException();

            var tokens = jwtService.CreateToken(new JwtPayload(admin.Id));

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                admin.AccessToken = tokens.AccessToken;
                admin.RefreshToken = tokens.RefreshToken;

                dbContext.Admins.Update(admin);
                await dbContext.SaveChangesAsync();

                var result = new RefreshTokenViewModel()
                {
                    AccessToken = tokens.AccessToken,
                    RefreshToken = tokens.RefreshToken
                };

                tran.Commit();

                return result;
            }
            catch
            {
                tran.Rollback();

                throw;
            }
        }
    }
}
