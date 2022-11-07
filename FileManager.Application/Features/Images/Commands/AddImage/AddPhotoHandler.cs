using FileManager.Application.Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FileManager.Application.Features.Photos.Commands.AddImage
{
    internal class AddPhotoHandler : IRequestHandler<AddPhotoCommand>
    {
        private readonly string WebRootPath;

        public AddPhotoHandler(DirectoryPathSettings wwwroot)
        {
            WebRootPath = wwwroot.WebRootPath;
        }

        public Task<Unit> Handle(AddPhotoCommand request, CancellationToken cancellationToken)
        {
            var path = Path.Combine(WebRootPath, "photos");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var image = Image.Load(request.PhotoFile.OpenReadStream());
            Resize(image, 500, 500);

            var fileName = GenerateFileName(request.PhotoFile);
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
