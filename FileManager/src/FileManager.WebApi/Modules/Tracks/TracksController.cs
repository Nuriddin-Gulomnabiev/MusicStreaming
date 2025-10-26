using FileManager.Application.Features.Tracks.Commands.AddTrack;
using FileManager.Application.Features.Tracks.Queries.GetTrack;
using FileManager.WebApi.Common.Controllers;
using FileManager.WebApi.Modules.Tracks.ModelRequests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.WebApi.Modules.Tracks
{
    [Route("api/v1/tracks")]
    public class TracksController : BaseController
    {
        public TracksController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpGet("{code}")]
        public async Task<FileStreamResult> GetTrack([FromRoute] int code)
        {
            var stream = await mediator.Send(new GetTrackQuery(code));

            return File(stream, "audio/mp3", true);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddTrack([FromForm] AddFileModelRequest request)
        {
            return Success(await mediator.Send(new AddTrackCommand(request.File)));
        }
    }
}
