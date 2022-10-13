using MediatR;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Application.Features.Albums.Queries.GetAlbum;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("api/v1/albums")]
    public class AlbumsController : ControllerBase
    {
        private readonly IMediator mediator;

        public AlbumsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetAlbum([FromRoute] int code)
        {
            return Ok(await mediator.Send(new GetAlbumQuery(code)));
        }
    }
}
