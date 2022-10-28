using MediatR;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Application.Features.Albums.Queries.GetAlbum;
using AdminPanel.Application.Features.Albums.Commands.CreateAlbum;
using AdminPanel.Application.Features.Albums.Commands.EditAlbum;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("api/v1/album")]
    public class AlbumsController : BaseController
    {
        private readonly IMediator mediator;

        public AlbumsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetAlbum([FromRoute] int code)
        {
            return Success(await mediator.Send(new GetAlbumQuery(code)));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateAlbum([FromBody] CreateAlbumCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [HttpPost("{code}/edit")]
        public async Task<IActionResult> EditAlbum([FromBody] EditAlbumCommand command, [FromRoute] int code)
        {
            command.Code = code;

            return Success(await mediator.Send(command));
        }
    }
}
