using FileManager.WebApi.Common.Filters;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.WebApi.Common.Controllers
{
    [ApiController]
    [TypeFilter((typeof(AuthorizationFilter)))]
    public class BaseController : Controller
    {
        protected readonly IMediator mediator;

        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [NonAction]
        public virtual IActionResult Success(Unit unit)
        {
            return Ok(new { status = true });
        }
    }
}
