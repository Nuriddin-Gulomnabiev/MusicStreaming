using Domain.Enums.ErrorCodes;
using Domain.Exceptions;
using Client.WebApi.Common.ModelResponses;
using Newtonsoft.Json;
using Domain.Utils;
using Domain.Common;

namespace Client.WebApi.Common.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public ErrorHandlerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            this.next = next;
            logger = loggerFactory.CreateLogger(GetType().Name);
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (ValidationException ex)
            {
                await WriteResponseAsync(context, new ErrorModelResponse((int)ex.Code, ex.Message, ex.Errors));
            }
            catch (BaseException ex)
            {
                await WriteResponseAsync(context, new ErrorModelResponse((int)ex.Code, ex.Message));
            }
            catch (Exception ex)
            {
                var logError = $"Message: {ex.Message}, ";

                if (ex?.InnerException?.Message != null)
                    logError += $"InnerException: {ex.InnerException.Message}, ";

                logError += $"StactTrace: {ex.StackTrace}";

                logger.LogError(logError);

                await WriteResponseAsync(context, new ErrorModelResponse((int)ErrorCodeEnum.UNKNOW_ERROR, "Неизвестная ошибка"));
            }
        }

        private static async Task WriteResponseAsync(HttpContext context, ErrorModelResponse response)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = HttpStatusCodeUtil.GetHttpStatusCodeByErrorCodeEnum(response.Code);

            await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
