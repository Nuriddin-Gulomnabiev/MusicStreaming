using MediatR;
using Microsoft.AspNetCore.Http;

namespace FileManager.Application.Features.Photos.Commands.AddImage
{
    public class AddPhotoCommand : IRequest
    {
        public IFormFile PhotoFile { get; }

        public AddPhotoCommand(IFormFile image)
        {
            PhotoFile = image;
        }
    }
}
