using Newtonsoft.Json;

namespace AdminPanel.Web.Common.ModelResponses
{
    public class ErrorModelResponse : BaseModelResponse
    {
        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<Error> Errors { get; set; }

        public ErrorModelResponse(int Code, string Message, IEnumerable<Error> errors = null) : base(Code, Message)
        {
            Errors = errors;
        }
    }

    public class Error
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
