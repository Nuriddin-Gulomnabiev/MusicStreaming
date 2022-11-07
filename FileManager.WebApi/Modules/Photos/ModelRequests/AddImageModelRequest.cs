using Newtonsoft.Json;

namespace FileManager.WebApi.Modules.Photos.ModelRequests
{
    public class AddPhotoModelRequest
    {
        [JsonProperty("file")]
        public IFormFile Image { get; set; }
    }
}
