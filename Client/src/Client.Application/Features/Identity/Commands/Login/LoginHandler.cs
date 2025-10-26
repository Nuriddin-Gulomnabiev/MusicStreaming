using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Helpers;
using Client.Application.Common.Interfaces;
using Domain.Entities.Artists;
using Domain.Entities.Sessions;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;
using Services.Services.JwtService;
using Services.Services.JwtService.ModelResponses;

namespace Client.Application.Features.Identity.Commands.Login
{
    internal class LoginHandler : BaseHandler, IRequestHandler<LoginCommand, LoginViewModel>
    {
        private readonly IJwtService jwtService;

        public LoginHandler(
            IClientApplicationDbContext dbContext,
            IMapper mapper,
            IJwtService jwtService,
            IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
            this.jwtService = jwtService;
        }

        public async Task<LoginViewModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var artist = await dbContext.Artists.Where(a => a.Email == request.Email && a.Password == request.Password).Include(a => a.Sessions).FirstOrDefaultAsync()
                ?? throw new UnauthorizedException("Неверно введённый логин и/или пароль");

            var tokens = jwtService.CreateToken(new JwtPayload(artist.Id, request.DeviceId));

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var session = artist.Sessions.Where(s => s.DeviceId == request.DeviceId).FirstOrDefault();

                if (session == null)
                {
                    AddNewSession(request, artist, tokens);
                }
                else
                {
                    UpdateSession(tokens, session);
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

        private void UpdateSession(Tokens tokens, Session session)
        {
            session.RefreshToken = tokens.RefreshToken;
            session.ExpiresAt = tokens.RefreshExpiresAt;

            dbContext.Sessions.Update(session);
        }

        private void AddNewSession(LoginCommand request, Artist artist, Tokens tokens)
        {
            Session session = new Session()
            {
                Id = Guid.NewGuid(),
                ArtistId = artist.Id,
                DeviceId = request.DeviceId,
                ExpiresAt = tokens.RefreshExpiresAt,
                RefreshToken = tokens.RefreshToken,
            };

            dbContext.Sessions.Add(session);
        }
    }
}
