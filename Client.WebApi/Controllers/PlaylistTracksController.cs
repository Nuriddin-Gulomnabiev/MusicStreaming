using Client.Application.Features.Playlists.Command.AddPlaylistTrack;
using Client.Application.Features.Playlists.Command.DeletePlaylistTrack;
using Client.Application.Features.Playlists.Command.MovePlaylistTrack;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Client.WebApi.Controllers
{
    [Route("api/v1/playlists/tracks")]
    public class PlaylistTracksController : BaseController
    {
        public PlaylistTracksController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("add")]
        public async Task<IActionResult> CreatePlaylistTrack([FromBody] AddPlaylistTrackCommand request)
        {
            return Success(await mediator.Send(request));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePlaylistTrack([FromBody] DeletePlaylistTrackCommand request)
        {
            return Success(await mediator.Send(request));
        }

        [HttpPost("move")]
        public async Task<IActionResult> DeletePlaylistTrack([FromBody] MovePlaylistTrackCommand request)
        {
            return Success(await mediator.Send(request));
        }
    }
}
