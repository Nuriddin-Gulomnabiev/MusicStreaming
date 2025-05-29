using Domain.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdminPanel.Web.Common.ModelResponses
{
    public class ErrorModelResponse : IActionResult
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

        public async Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = HttpStatusCodeHelper.GetHttpStatusCodeByErrorCodeEnum(Code);

            await context.HttpContext.Response.WriteAsync(JsonConvert.SerializeObject(this));
        }
    }
}
