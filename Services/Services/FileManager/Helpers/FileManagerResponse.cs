namespace Services.Services.FileManager.Helpers
{
    public class FileManagerResponse
    {
        public bool Status { get; set; }
        public int Code { get; set; }
        public Dictionary<string, IEnumerable<string>> Errors { get; set; }
    }
}
