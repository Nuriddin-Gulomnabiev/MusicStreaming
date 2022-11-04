using Newtonsoft.Json;

namespace FileManager.WebApi.Modules.Tracks.ModelRequests
{
    public class AddFileModelRequest
    {
        [JsonProperty("file")]
        public IFormFile File { get; set; }
    }
}
