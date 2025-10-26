using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AdminPanel.Web.Common.ModelResponses
{
    public class SuccessModelResponse : IActionResult
    {
        [JsonProperty("status")]
        public bool Status => true;

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; }

        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public object Meta { get; }

        public SuccessModelResponse()
        {
        }

        public SuccessModelResponse(object data)
        {
            Data = data;
        }

        public SuccessModelResponse(object data, object meta)
        {
            Data = data;
            Meta = meta;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status200OK;
            context.HttpContext.Response.ContentType = "application/json";

            string responseJson = JsonConvert.SerializeObject(this, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            await context.HttpContext.Response.WriteAsync(responseJson);
        }
    }
}
