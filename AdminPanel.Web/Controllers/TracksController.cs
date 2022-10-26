using AdminPanel.Application.Features.Tracks.Commands.CreateTrack;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("api/v1/tracks")]
    public class TracksController : ControllerBase
    {
        private readonly IMediator mediator;

        public TracksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTrack([FromForm] CreateTrackCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
