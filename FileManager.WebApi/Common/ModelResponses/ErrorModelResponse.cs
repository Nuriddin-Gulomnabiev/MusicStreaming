using Newtonsoft.Json;

namespace FileManager.WebApi.Common.ModelResponses
{
    public class ErrorModelResponse
    {
        [JsonProperty("status")]
        public bool Status => false;

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, IEnumerable<string>> Errors { get; set; }

        public ErrorModelResponse(int code, string message = null)
        {
            Code = code;
            Message = message;
        }

        public ErrorModelResponse(int code, string message = null, Dictionary<string, IEnumerable<string>> errors = null)
        {
            Code = code;
            Errors = errors;
            Message = message;
        }
    }
}
