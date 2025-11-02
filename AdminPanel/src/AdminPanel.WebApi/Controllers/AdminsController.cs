using AdminPanel.Application.Features.Admins.Queries.GetAllAdmins;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.WebApi.Controllers
{
    [Route("api/v{version:apiVersion}/admins")]
    public class AdminsController : BaseController
    {
        public AdminsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Success(await mediator.Send(new GetAllAdminsQuery()));
        }
    }
}
