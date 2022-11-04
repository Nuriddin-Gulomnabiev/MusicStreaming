namespace FileManager.Application.Common.Helpers
{
    public class DirectoryPathSettings
    {
        public string WebRootPath { get; }

        public DirectoryPathSettings(string rootPath)
        {
            WebRootPath = rootPath;
        }
    }
}
