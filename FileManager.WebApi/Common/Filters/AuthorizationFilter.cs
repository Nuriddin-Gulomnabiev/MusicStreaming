using Domain.Exceptions;
using Shared.Helpers.Hash;
using FileManager.WebApi.Common.Helpers;
using Microsoft.Extensions.Primitives;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Authorization;

namespace FileManager.WebApi.Common.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        private readonly IConfiguration configuration;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AuthorizationFilter(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            this.configuration = configuration;
            this.httpContextAccessor = httpContextAccessor;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any())
                return;

            if (!httpContextAccessor.HttpContext.Request.Host.HasValue
                || !httpContextAccessor.HttpContext.Request.Headers.TryGetValue("token", out StringValues token)
                || !httpContextAccessor.HttpContext.Request.Headers.TryGetValue("datetime", out StringValues datetime)
                || !httpContextAccessor.HttpContext.Request.Headers.TryGetValue("hash", out StringValues hash)
                )
                throw new UnauthorizedException();

            var host = httpContextAccessor.HttpContext.Request.Host.Value;

            var allowedHosts = configuration.GetSection("AllowedHostsWithKey").Get<List<AllowedHostWithKey>>();

            var allowedHost = allowedHosts.Where(a => a.Host == host).FirstOrDefault()
                ?? throw new UnauthorizedException();

            if (HashService.Sha256($"{token}:{allowedHost.Key}:{datetime}") != hash)
                throw new UnauthorizedException();

            if (context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any())
                return;
        }
    }
}
