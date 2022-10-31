using AdminPanel.Application.Features.Albums.Commands.CreateAlbum;
using AdminPanel.Application.Features.Albums.Commands.EditAlbum;
using AdminPanel.Application.Features.Albums.Queries.GetAlbum;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [Route("api/v1/album")]
    public class AlbumsController : BaseController
    {
        public AlbumsController(IMediator mediator) : base(mediator)
        {
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
