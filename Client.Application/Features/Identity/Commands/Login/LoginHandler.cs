using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Entities.Sessions;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.JwtService;

namespace Client.Application.Features.Identity.Commands.Login
{
    internal class LoginHandler : BaseCommandQueryHandler, IRequestHandler<LoginCommand, LoginViewModel>
    {
        private readonly IJwtService jwtService;

        public LoginHandler(IClientApplicationDbContext dbContext, IMapper mapper, IJwtService jwtService) : base(dbContext, mapper)
        {
            this.jwtService = jwtService;
        }

        public async Task<LoginViewModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var artist = await dbContext.Artists.Where(a => a.Email == request.Email && a.Password == request.Password).Include(a => a.Sessions).FirstOrDefaultAsync()
                ?? throw new UnauthorizedException("Неверно введённый логин и/или пароль");

            var tokens = jwtService.CreateToken(artist.Id);

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var session = artist.Sessions.Where(s => s.DeviceId == request.DeviceId).FirstOrDefault();

                if (session == null)
                {
                    session = new Session()
                    {
                        Id = Guid.NewGuid(),
                        ArtistId = artist.Id,
                        DeviceId = request.DeviceId,
                        ExpiresAt = tokens.RefreshExpiresAt,
                        RefreshToken = tokens.RefreshToken,
                    };

                    dbContext.Sessions.Add(session);
                }
                else
                {
                    session.RefreshToken = tokens.RefreshToken;
                    session.ExpiresAt = tokens.RefreshExpiresAt;

                    dbContext.Sessions.Update(session);
                }

                await dbContext.SaveChangesAsync();

                tran.Commit();

                var result = new LoginViewModel()
                {
                    AccessToken = tokens.AccessToken,
                    RefreshToken = tokens.RefreshToken
                };

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
