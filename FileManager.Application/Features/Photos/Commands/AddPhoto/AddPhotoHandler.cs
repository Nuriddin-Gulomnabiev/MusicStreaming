using FileManager.Application.Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FileManager.Application.Features.Photos.Commands.AddPhoto
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
            var fileName = GenerateFileName(request.PhotoFile);

            var image = Image.Load(request.PhotoFile.OpenReadStream());

            SaveOriginal(image, fileName);
            SaveThumbnail(image, fileName);

            return Task.FromResult(Unit.Value);
        }

        private void SaveOriginal(Image photo, string fileName)
        {
            var folderPath = Path.Combine(WebRootPath, "photos");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            using var copy = photo.Clone(x => x.Resize(photo.Width / 2, photo.Height / 2));

            var filePath = Path.Combine(folderPath, fileName);

            copy.Save(filePath);
        }

        private void SaveThumbnail(Image photo, string fileName)
        {
            var folderPath = Path.Combine(WebRootPath, "photos", "thumbnails");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            using var copy = photo.Clone(x => x.Resize(photo.Width / 3, photo.Height / 3));

            var filePath = Path.Combine(folderPath, fileName);

            copy.Save(filePath);
        }

        private static string GenerateFileName(IFormFile file)
        {
            var fileExtension = Path.GetExtension(file.FileName);
            var fileName = Path.GetFileNameWithoutExtension(file.FileName);

            return $"{fileName}{fileExtension}";
        }
    }
}
