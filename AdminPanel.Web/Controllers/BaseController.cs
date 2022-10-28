using AdminPanel.Web.Common.ModelResponses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Web.Controllers
{
    public abstract class BaseController : ControllerBase
    {
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
