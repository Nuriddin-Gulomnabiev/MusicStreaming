using FileManager.Application.Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FileManager.Application.Features.Covers.Commands.AddCover
{
    public class AddCoverHandler : IRequestHandler<AddCoverCommand>
    {
        private readonly string WebRootPath;
        private readonly string CoversFolderPath;

        public AddCoverHandler(DirectoryPathSettings wwwroot)
        {
            WebRootPath = wwwroot.WebRootPath;
            CoversFolderPath = Path.Combine(WebRootPath, "covers");
        }

        public Task<Unit> Handle(AddCoverCommand request, CancellationToken cancellationToken)
        {
            var coverName = GenerateFileName(request.CoverFile);

            var cover = Image.Load(request.CoverFile.OpenReadStream());

            var sizes = new int[] { 100, 200, 400, 600, 800, 1000 };

            foreach (var size in sizes)
            {
                var sizeFolder = (size / 100).ToString();

                SaveCover(cover, coverName, sizeFolder, size);
            }

            return Task.FromResult(Unit.Value);
        }

        private void SaveCover(Image cover, string fileName, string sizeFolder, int size)
        {
            var folder = Path.Combine(CoversFolderPath, sizeFolder);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var copy = cover.Clone(x => x.Resize(size, size));

            var filePath = Path.Combine(folder, fileName);

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
