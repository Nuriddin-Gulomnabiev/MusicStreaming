using MediatR;
using Microsoft.AspNetCore.Http;

namespace FileManager.Application.Features.Photos.Commands.AddPhoto
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
