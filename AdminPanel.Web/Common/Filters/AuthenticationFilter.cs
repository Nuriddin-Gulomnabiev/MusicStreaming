using Domain.Exceptions;
using AdminPanel.Application.Common.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Services.Services.JwtService.Exceptions;
using Services.Services.IdentifiedService;

namespace AdminPanel.Web.Common.Filters
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

            if (!Guid.TryParse(data, out Guid userId))
                throw new TokenInvalidException();

            var token = GetBearerToken(context.HttpContext);

            var admin = dbContext.Admins.Where(a => a.Id == userId && a.AccessToken == token).FirstOrDefault()
                ?? throw new TokenExpiredException();

            identifiedService.SetToken(token);
            identifiedService.SetUserId(userId);
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
