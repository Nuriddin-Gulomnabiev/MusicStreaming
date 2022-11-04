using FileManager.WebApi.Modules.Tracks.ModelRequests;
using FileManager.Application.Features.Tracks.Commands.AddTrack;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using FileManager.Application.Features.Tracks.Queries.GetTrack;

namespace FileManager.WebApi.Modules.Tracks
{
    [Route("api/v1/track")]
    public class TracksController : Controller
    {
        private readonly IMediator mediator;

        public TracksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{code}")]
        public async Task<FileStreamResult> GetTrack([FromRoute] int code)
        {
            var stream = await mediator.Send(new GetTrackQuery(code));

            return File(stream, "audio/mp3", true);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTrack([FromForm] AddFileModelRequest request)
        {
            await mediator.Send(new AddTrackCommand(request.File));

            return Ok();
        }
    }
}
