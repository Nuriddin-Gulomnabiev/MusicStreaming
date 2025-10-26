using Client.Application.Features.Playlists.Command.CreatePlaylist;
using Client.Application.Features.Playlists.Command.DeletePlaylist;
using Client.Application.Features.Playlists.Command.EditPlaylist;
using Client.Application.Features.Playlists.Query.GetMyPlaylists;
using Client.Application.Features.Playlists.Query.GetPlaylist;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Client.WebApi.Controllers
{
    [Route("api/v1/playlists")]
    public class PlaylistsController : BaseController
    {
        public PlaylistsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetMyPlaylists()
        {
            return Success(await mediator.Send(new GetMyPlaylistsQuery()));
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetMyPlaylists([FromRoute] int code)
        {
            return Success(await mediator.Send(new GetPlaylistQuery(code)));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreatePlaylist([FromBody] CreatePlaylistCommand request)
        {
            return Success(await mediator.Send(request));
        }

        [HttpPost("edit")]
        public async Task<IActionResult> RenamePlaylist([FromBody] EditPlaylistCommand request)
        {
            return Success(await mediator.Send(request));
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePlaylist([FromBody] DeletePlaylistCommand request)
        {
            return Success(await mediator.Send(request));
        }
    }
}
