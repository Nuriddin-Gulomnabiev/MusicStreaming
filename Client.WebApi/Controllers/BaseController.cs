using Client.WebApi.Common.ModelResponses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Client.WebApi.Controllers
{
    [ApiController]
    //[TypeFilter((typeof(AuthenticationFilter)))]
    public abstract class BaseController : ControllerBase
    {
        protected readonly IMediator mediator;

        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [NonAction]
        public virtual IActionResult Success(Unit unit)
        {
            return new SuccessModelResponse();
        }

        [NonAction]
        public virtual IActionResult Success(object data)
        {
            return new SuccessModelResponse(data);
        }
    }
}
