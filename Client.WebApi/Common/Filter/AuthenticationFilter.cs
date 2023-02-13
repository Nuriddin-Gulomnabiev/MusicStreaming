using Microsoft.AspNetCore.Mvc.Filters;

namespace Client.WebApi.Common.Filter
{
    public class AuthenticationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}
