using FileManager.Application.Common.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FileManager.Application.Features.Icons.Commands.AddIcon
{
    public class AddCoverHandler : IRequestHandler<AddIconCommand>
    {
        private readonly string WebRootPath;
        private readonly string IconsFolderPath;

        public AddCoverHandler(DirectoryPathSettings wwwroot)
        {
            WebRootPath = wwwroot.WebRootPath;
            IconsFolderPath = Path.Combine(WebRootPath, "icons");
        }

        public Task<Unit> Handle(AddIconCommand request, CancellationToken cancellationToken)
        {
            var iconName = GenerateFileName(request.IconFile);

            var icon = Image.Load(request.IconFile.OpenReadStream());

            SaveIcon(icon, iconName, "1", 24);
            SaveIcon(icon, iconName, "2", 64);
            SaveIcon(icon, iconName, "3", 96);
            SaveIcon(icon, iconName, "ldpi", 36);
            SaveIcon(icon, iconName, "mdpi", 48);
            SaveIcon(icon, iconName, "tvdpi", 64);
            SaveIcon(icon, iconName, "hdpi", 72);
            SaveIcon(icon, iconName, "xhdpi", 96);
            SaveIcon(icon, iconName, "xxhdpi", 144);
            SaveIcon(icon, iconName, "xxxhdpi", 192);

            return Task.FromResult(Unit.Value);
        }

        private void SaveIcon(Image icon, string fileName, string sizeFolder, int size)
        {
            var folder = Path.Combine(IconsFolderPath, sizeFolder);

            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            var copy = icon.Clone(x => x.Resize(size, size));

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
