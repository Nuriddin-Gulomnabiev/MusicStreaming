using Client.Application.Features.Identity.Commands.Login;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Client.WebApi.Controllers
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

        /*[HttpPost("logout")]
        public async Task<IActionResult> Logout([FromBody] LoginCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [RefreshToken]
        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh()
        {
            return Success(await mediator.Send(new RefreshTokenCommand()));
        }*/
    }
}
