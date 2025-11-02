using AdminPanel.Application.Features.Tracks.Commands.CreateTrack;
using AdminPanel.Application.Features.Tracks.Commands.EditTrack;
using AdminPanel.Application.Features.Tracks.Commands.EditTrackStatus;
using AdminPanel.Application.Features.Tracks.Queries.GetAllTracks;
using AdminPanel.Application.Features.Tracks.Queries.GetTrack;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/tracks")]
    public class TracksController : BaseController
    {
        public TracksController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetTracks([FromQuery] GetAllTracksQuery query)
        {
            return Success(await mediator.Send(query));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTrack([FromForm] CreateTrackCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetTrack([FromRoute] int code)
        {
            return Success(await mediator.Send(new GetTrackQuery(code)));
        }

        [HttpPost("{code}/edit")]
        public async Task<IActionResult> EditTrack([FromForm] EditTrackCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [HttpPost("{code}/enable")]
        public async Task<IActionResult> EnableTrack([FromRoute] int code)
        {
            return Success(await mediator.Send(new EditTrackStatusCommand(code, true)));
        }

        [HttpPost("{code}/disable")]
        public async Task<IActionResult> DisableTrack([FromRoute] int code)
        {
            return Success(await mediator.Send(new EditTrackStatusCommand(code, false)));
        }
    }
}
