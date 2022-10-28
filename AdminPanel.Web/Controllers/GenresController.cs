using AdminPanel.Application.Features.Genres.Commands.CreateGenre;
using AdminPanel.Application.Features.Genres.Commands.EditGenre;
using AdminPanel.Application.Features.Genres.Queries.GetGenre;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("api/v1/genre")]
    public class GenresController : ControllerBase
    {
        private readonly IMediator mediator;

        public GenresController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetGenre([FromRoute] int code, CancellationToken cancellationToken)
        {
            return Ok(await mediator.Send(new GetGenreQuery(code), cancellationToken));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateGenre([FromBody] CreateGenreCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        [HttpPost("{code}/edit")]
        public async Task<IActionResult> EditGenre([FromBody] EditGenreCommand command, [FromRoute] int code)
        {
            command.Code = code;

            return Ok(await mediator.Send(command));
        }
    }
}
