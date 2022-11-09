using Newtonsoft.Json;

namespace FileManager.WebApi.Modules.Images.ModelRequests
{
    public class AddImageModelRequest
    {
        [JsonProperty("file")]
        public IFormFile Image { get; set; }
    }
}
