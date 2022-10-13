using MediatR;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Application.Features.Artists.Commands.CreateArtist;
using AdminPanel.Application.Features.Artists.Queries.GetAllArtists;
using AdminPanel.Application.Features.Artists.Queries.GetArtist;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("api/v1/artists")]
    public class ArtistsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ArtistsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return Ok(await mediator.Send(new GetAllArtistsQuery(), cancellationToken));
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetArtist([FromRoute] int code, CancellationToken cancellationToken)
        {
            return Ok(await mediator.Send(new GetArtistQuery(code), cancellationToken));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateArtist([FromBody] CreateArtistCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
