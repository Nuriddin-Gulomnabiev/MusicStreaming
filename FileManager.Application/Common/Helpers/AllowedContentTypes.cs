using FileManager.Application.Common.Enums;

namespace FileManager.Application.Common.Helpers
{
    public class AllowedContentTypes
    {
        public string Section => "AllowedContentTypes";

        public List<string> Icon { get; set; }
        public List<string> Audio { get; set; }
        public List<string> Cover { get; set; }
        public List<string> Photo { get; set; }

        public bool IsImageAllowed(ImageTypeEnum imageType, string contentType)
        {
            var allowedTypes = new List<string>();

            switch (imageType)
            {
                case ImageTypeEnum.Icon:
                    allowedTypes = Icon;
                    break;
                case ImageTypeEnum.Cover:
                    allowedTypes = Cover;
                    break;
                case ImageTypeEnum.Photo:
                    allowedTypes = Photo;
                    break;
                default:
                    break;
            }

            return allowedTypes.Contains(contentType);
        }
    }
}
