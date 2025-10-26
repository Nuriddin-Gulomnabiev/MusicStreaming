namespace Services.Services.FileManager.Helpers
{
    public class FileManagerSettings
    {
        public string Section { get; } = "FileManager";
        public string Key { get; set; }
        public string Url { get; set; }
        public int Timeout { get; set; }
    }
}
