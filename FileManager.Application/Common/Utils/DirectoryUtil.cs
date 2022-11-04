using FileManager.Application.Common.Enums;

namespace FileManager.Application.Common.Utils
{
    internal static class DirectoryUtil
    {
        public static string GetDirectoryNameByEnum(ImageTypeEnum directory)
        {
            return directory switch
            {
                ImageTypeEnum.Cover => "covers",
                ImageTypeEnum.Photo => "photos",
                ImageTypeEnum.Icon => "icons",
                _ => throw new Exception($"Unhandled value '{directory}' of enum '{nameof(ImageTypeEnum)}'"),
            };
        }
    }
}
