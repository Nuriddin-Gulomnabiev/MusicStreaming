using FileManager.Application.Common.Helpers;
using FileManager.Application.Common.Utils;
using MediatR;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FileManager.Application.Features.Images.Commands.AddImage
{
    internal class AddImageHandler : IRequestHandler<AddImageCommand>
    {
        private readonly string WebRootPath;

        public AddImageHandler(DirectoryPathSettings wwwroot)
        {
            WebRootPath = wwwroot.WebRootPath;
        }


        public Task<Unit> Handle(AddImageCommand request, CancellationToken cancellationToken)
        {
            var directory = DirectoryUtil.GetDirectoryNameByEnum(request.ImageType);

            var path = Path.Combine(WebRootPath, $"{directory}");
            var fileName = GenerateFileName(request.ImageFile);

            var image = Image.Load(request.ImageFile.OpenReadStream());
            Resize(image, 500, 500);

            var filePath = Path.Combine(path, fileName);

            image.Save(filePath);

            return Task.FromResult(Unit.Value);
        }

        private static string GenerateFileName(IFormFile file)
        {
            var fileExtension = Path.GetExtension(file.FileName);
            var fileName = Path.GetFileNameWithoutExtension(file.FileName);

            return $"{fileName}{fileExtension}";
        }

        private static void Resize(Image image, int width, int height)
        {
            var resizeOptions = new ResizeOptions
            {
                Size = new Size(width, height)
            };

            image.Mutate(action => action.Resize(resizeOptions));
        }
    }
}
