using AdminPanel.Application.Features.Identity.Commands.Login;
using AdminPanel.Application.Features.Identity.Commands.RefreshToken;
using AdminPanel.Web.Common.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [Route("api/v1/identity")]
    public class IdentityController : BaseController
    {
        public IdentityController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [RefreshToken]
        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh()
        {
            return Success(await mediator.Send(new RefreshTokenCommand()));
        }
    }
}
