using MediatR;
using Microsoft.AspNetCore.Http;
using FileManager.Application.Common.Enums;

namespace FileManager.Application.Features.Images.Commands.AddImage
{
    public class AddImageCommand : IRequest
    {
        public IFormFile ImageFile { get; set; }
        public ImageTypeEnum ImageType { get; set; }

        public AddImageCommand(IFormFile image, ImageTypeEnum imageType)
        {
            ImageFile = image;
            ImageType = imageType;
        }
    }
}
