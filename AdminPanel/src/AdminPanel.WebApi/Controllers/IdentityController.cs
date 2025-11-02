using AdminPanel.Application.Features.Identity.Commands.Login;
using AdminPanel.Application.Features.Identity.Commands.RefreshToken;
using AdminPanel.WebApi.Common.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/identity")]
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

        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] LoginCommand command)
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
