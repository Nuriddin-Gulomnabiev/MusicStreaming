using Newtonsoft.Json;

namespace AdminPanel.Web.Common.ModelResponses
{
    public abstract class BaseModelResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public BaseModelResponse(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
