using Domain.Exceptions;
using AdminPanel.Application.Common.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Services.Services.JwtService.Exceptions;

namespace AdminPanel.Web.Common.Filters
{
    public class AuthenticationFilter : IAuthorizationFilter
    {
        private readonly IAdminApplicationDbContext dbContext;

        public AuthenticationFilter(IAdminApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any())
                return;

            var userId = context.HttpContext.User.FindFirst("data")?.Value
                ?? throw new TokenInvalidException();

            var token = GetBearerToken(context.HttpContext);

            var admin = dbContext.Admins.Where(a => a.Id == new Guid(userId) && a.AccessToken == token).FirstOrDefault()
                ?? throw new TokenExpiredException();
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
