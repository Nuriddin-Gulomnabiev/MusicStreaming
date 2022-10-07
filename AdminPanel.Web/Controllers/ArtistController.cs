using MediatR;
using Microsoft.AspNetCore.Mvc;
using AdminPanel.Application.Features.Artists.Commands.CreateArtist;

namespace AdminPanel.Web.Controllers
{
    [ApiController]
    [Route("api/v1/artists")]
    public class ArtistController : ControllerBase
    {
        private readonly IMediator mediator;

        public ArtistController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateArtist([FromBody] CreateArtistCommand command, CancellationToken cancellationToken)
        {
            var artist = await mediator.Send(command, cancellationToken);

            return Ok(artist);
        }
    }
}
