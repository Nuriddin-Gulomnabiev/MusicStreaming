using Newtonsoft.Json;

namespace Client.Web.Services.ApiHttpService.Models
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }

        public T Data { get; set; }

        public int? ErrorCode { get; set; }

        public string ErrorMessage { get; set; }

        public Dictionary<string, IEnumerable<string>> ValidationErrors { get; set; }
    }

    public class SuccessWrapper<T>
    {
        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }
    }

    public class ErrorWrapper<T>
    {
        [JsonProperty("status")]
        public bool Status { get; set; } = false;

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public Dictionary<string, IEnumerable<string>> Errors { get; set; }
    }
}
