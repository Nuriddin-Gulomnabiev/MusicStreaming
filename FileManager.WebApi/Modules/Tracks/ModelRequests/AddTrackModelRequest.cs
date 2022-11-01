using Newtonsoft.Json;

namespace FileManager.WebApi.Modules.Tracks.ModelRequests
{
    public class AddFileModelRequest
    {
        [JsonProperty("fileName")]
        public Guid FileName { get; set; }

        [JsonProperty("file")]
        public IFormFile File { get; set; }
    }
}
