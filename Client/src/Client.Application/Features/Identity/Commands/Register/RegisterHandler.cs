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

namespace Client.Application.Features.Identity.Commands.Register
{
    internal class RegisterHandler : BaseHandler, IRequestHandler<RegisterCommand, RegisterViewModel>
    {
        private readonly IJwtService jwtService;

        public RegisterHandler(
            IClientApplicationDbContext dbContext,
            IMapper mapper,
            IJwtService jwtService,
            IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
            this.jwtService = jwtService;
        }

        public async Task<RegisterViewModel> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var existArtist = await dbContext.Artists
                .Where(a => a.Email == request.Email)
                .AsNoTracking()
                .FirstOrDefaultAsync()
                ?? throw new UnauthorizedException("Данный email уже занят");

            var artist = new Artist
            {
                Id = Guid.NewGuid(),
                Name = "User",
                Email = request.Email,
                IsActive = true,
                Password = request.Password,
            };

            var tokens = jwtService.CreateToken(new JwtPayload(artist.Id, request.DeviceId));

            var session = new Session()
            {
                Id = Guid.NewGuid(),
                ArtistId = artist.Id,
                DeviceId = request.DeviceId,
                ExpiresAt = tokens.RefreshExpiresAt,
                RefreshToken = tokens.RefreshToken,
            };

            dbContext.Artists.Add(artist);
            dbContext.Sessions.Add(session);

            await dbContext.SaveChangesAsync();

            var result = new RegisterViewModel()
            {
                AccessToken = tokens.AccessToken,
                RefreshToken = tokens.RefreshToken
            };

            return result;
        }
    }
}
