using Client.Application.Features.Albums.Queries.GetAlbum;
using Client.Application.Features.Albums.Queries.GetAllAlbums;
using Client.Application.Features.Albums.Queries.GetMyAlbums;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Client.WebApi.Controllers
{
    [Route("api/v1/albums")]
    public class AlbumsController : BaseController
    {
        public AlbumsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllAlbumsQuery request)
        {
            return Success(await mediator.Send(request));
        }

        [HttpGet("my")]
        public async Task<IActionResult> GetMy()
        {
            return Success(await mediator.Send(new GetMyAlbumsQuery()));
        }

        [HttpGet("{albumCode}")]
        public async Task<IActionResult> GetAll([FromRoute] int albumCode )
        {
            return Success(await mediator.Send(new GetAlbumQuery() { AlbumCode = albumCode }));
        }
    }
}
