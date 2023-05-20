using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Helpers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.JwtService;

namespace AdminPanel.Application.Features.Identity.Commands.Login
{
    internal class LoginHandler : BaseCommandQueryHandler, IRequestHandler<LoginCommand, LoginViewModel>
    {
        private readonly IJwtService jwtService;

        public LoginHandler(IAdminApplicationDbContext dbContext, IMapper mapper, IJwtService jwtService) : base(dbContext, mapper)
        {
            this.jwtService = jwtService;
        }

        public async Task<LoginViewModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var admin = await dbContext.Admins.Where(a => a.Login == request.Login && a.Password == request.Password).FirstOrDefaultAsync()
                ?? throw new UnauthorizedException("Неверно введённый логин и/или пароль");

            var tokens = jwtService.CreateToken(new JwtPayload(admin.Id));

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                admin.AccessToken = tokens.AccessToken;
                admin.RefreshToken = tokens.RefreshToken;

                dbContext.Admins.Update(admin);
                await dbContext.SaveChangesAsync();

                var result = new LoginViewModel()
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
