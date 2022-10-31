using AdminPanel.Application.Common.Enums;
using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Web.Common.ModelResponses;
using AdminPanel.Web.Common.Utils;
using Newtonsoft.Json;
using Services.Services.JwtService.Exceptions;

namespace AdminPanel.Web.Common.Middlewares
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
                IEnumerable<Error> errors = null;

                if (ex.Errors != null && ex.Errors.Any())
                {
                    errors = ex.Errors.Select(e => new Error { ErrorMessage = e.ErrorMessage, PropertyName = e.PropertyName });
                }

                await WriteResponseAsync(context, new ErrorModelResponse((int)ex.Code, ex.Message, errors));
            }
            catch (BaseException ex)
            {
                await WriteResponseAsync(context, new ErrorModelResponse((int)ex.Code, ex.Message));
            }
            catch (TokenExpiredException ex)
            {
                await WriteResponseAsync(context, new ErrorModelResponse((int)ErrorCodeEnum.UNAUTHORIZED_ERROR, ex.Message));
            }
            catch (TokenInvalidException ex)
            {
                await WriteResponseAsync(context, new ErrorModelResponse((int)ErrorCodeEnum.UNAUTHORIZED_ERROR, ex.Message));
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
