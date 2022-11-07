using FileManager.Application.Features.Photos.Commands.AddImage;
using FileManager.WebApi.Common.Controllers;
using FileManager.WebApi.Modules.Photos.ModelRequests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.WebApi.Modules.Photos
{
    [Route("api/v1/photo")]
    public class PhotosController : BaseController
    {
        public PhotosController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddPhoto([FromForm] AddPhotoModelRequest request)
        {
            return Success(await mediator.Send(new AddPhotoCommand(request.Image)));
        }
    }
}
