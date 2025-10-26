using FileManager.Application.Features.Covers.Commands.AddCover;
using FileManager.Application.Features.Icons.Commands.AddIcon;
using FileManager.Application.Features.Photos.Commands.AddPhoto;
using FileManager.WebApi.Common.Controllers;
using FileManager.WebApi.Modules.Images.ModelRequests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FileManager.WebApi.Modules.Images
{
    [Route("api/v1/")]
    public class ImagesController : BaseController
    {
        public ImagesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("photos/add")]
        public async Task<IActionResult> AddPhoto([FromForm] AddImageModelRequest request)
        {
            return Success(await mediator.Send(new AddPhotoCommand(request.Image)));
        }

        [HttpPost("icons/add")]
        public async Task<IActionResult> AddIcon([FromForm] AddImageModelRequest request)
        {
            return Success(await mediator.Send(new AddIconCommand(request.Image)));
        }

        [HttpPost("covers/add")]
        public async Task<IActionResult> AddCover([FromForm] AddImageModelRequest request)
        {
            return Success(await mediator.Send(new AddCoverCommand(request.Image)));
        }
    }
}
