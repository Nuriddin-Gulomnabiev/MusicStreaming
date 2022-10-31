using AdminPanel.Application.Features.Artists.Commands.CreateArtist;
using AdminPanel.Application.Features.Artists.Commands.EditArtist;
using AdminPanel.Application.Features.Artists.Commands.EditArtistStatus;
using AdminPanel.Application.Features.Artists.Queries.GetAllArtists;
using AdminPanel.Application.Features.Artists.Queries.GetArtist;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    [Route("api/v1/artist")]
    public class ArtistsController : BaseController
    {
        public ArtistsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            return Success(await mediator.Send(new GetAllArtistsQuery(), cancellationToken));
        }

        [HttpGet("{code}")]
        public async Task<IActionResult> GetArtist([FromRoute] int code, CancellationToken cancellationToken)
        {
            return Success(await mediator.Send(new GetArtistQuery(code), cancellationToken));
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateArtist([FromBody] CreateArtistCommand command)
        {
            return Success(await mediator.Send(command));
        }

        [HttpPost("{code}/edit")]
        public async Task<IActionResult> EditArtist([FromBody] EditArtistCommand command, [FromRoute] int code)
        {
            command.Code = code;

            return Success(await mediator.Send(command));
        }

        [HttpPost("{code}/enable")]
        public async Task<IActionResult> EnableArtist([FromRoute] int code)
        {
            return Success(await mediator.Send(new EditArtistStatusCommand(code, true)));
        }

        [HttpPost("{code}/disable")]
        public async Task<IActionResult> DisableArtist([FromRoute] int code)
        {
            return Success(await mediator.Send(new EditArtistStatusCommand(code, false)));
        }
    }
}
