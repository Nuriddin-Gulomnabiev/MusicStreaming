using Client.Application.Features.Artists.Queries.GetAllArtists;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Client.WebApi.Controllers
{
    [Route("api/v1/artists")]
    public class ArtistsController : BaseController
    {
        public ArtistsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Success(await mediator.Send(new GetAllArtistsQuery()));
        }
    }
}
