using Client.Application.Common.Helpers;
using Client.Application.Common.Interfaces;
using Client.WebApi.Common.Attributes;
using Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Services.Services.IdentifiedService;
using Services.Services.JwtService.Exceptions;

namespace Client.WebApi.Common.Filter
{
    public class AuthenticationFilter : IAuthorizationFilter
    {
        private readonly IClientApplicationDbContext dbContext;
        private readonly IIdentifiedService identifiedService;

        public AuthenticationFilter(IClientApplicationDbContext dbContext, IIdentifiedService identifiedService)
        {
            this.dbContext = dbContext;
            this.identifiedService = identifiedService;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any())
                return;

            var data = context.HttpContext.User.FindFirst("data")?.Value
                ?? throw new TokenInvalidException();

            var payload = JsonConvert.DeserializeObject<JwtPayload>(data);

            if (payload?.UserId == null)
                throw new TokenInvalidException();

            var token = GetBearerToken(context.HttpContext);

            var session = dbContext.Sessions.Where(a => a.DeviceId == payload.DeviceId).FirstOrDefault()
                ?? throw new TokenInvalidException();

            if (context.ActionDescriptor.EndpointMetadata.OfType<RefreshTokenAttribute>().Any() && session.RefreshToken != token)
            {
                throw new TokenExpiredException();
            }

            identifiedService.SetToken(token);
            identifiedService.SetUserId(payload.UserId);
            identifiedService.SetPayload(payload);
        }

        private static string GetBearerToken(HttpContext context)
        {
            string headerAuth = context.Request.Headers["Authorization"];

            if (string.IsNullOrEmpty(headerAuth) || !headerAuth.StartsWith("Bearer "))
            {
                throw new UnauthorizedException("Токен не найден");
            }

            var token = headerAuth[7..];

            if (string.IsNullOrEmpty(token))
                throw new UnauthorizedException("Токен не найден");

            return token;
        }
    }
}
