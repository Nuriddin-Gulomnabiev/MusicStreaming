using AdminPanel.Application.Common.Helpers;
using AdminPanel.Application.Common.Interfaces;
using AdminPanel.WebApi.Common.Attributes;
using Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Services.Services.IdentifiedService;
using Services.Services.JwtService.Exceptions;

namespace AdminPanel.WebApi.Common.Filters
{
    public class AuthenticationFilter : IAuthorizationFilter
    {
        private readonly IAdminApplicationDbContext dbContext;
        private readonly IIdentifiedService identifiedService;

        public AuthenticationFilter(IAdminApplicationDbContext dbContext, IIdentifiedService identifiedService)
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

            var getAdminQuery = dbContext.Admins.Where(a => a.Id == payload.UserId);

            if (context.ActionDescriptor.EndpointMetadata.OfType<RefreshTokenAttribute>().Any())
            {
                getAdminQuery = getAdminQuery.Where(a => a.RefreshToken == token);
            }
            else
            {
                getAdminQuery = getAdminQuery.Where(a => a.AccessToken == token);
            }

            var admin = getAdminQuery.FirstOrDefault()
                ?? throw new TokenExpiredException();

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
