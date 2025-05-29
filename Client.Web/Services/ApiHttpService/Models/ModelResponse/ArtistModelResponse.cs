using Newtonsoft.Json;

namespace Client.Web.Services.ApiHttpService.Models.ModelResponse
{
    public class ArtistModelResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("albumCount")]
        public int AlbumCount { get; set; }
    }
}
