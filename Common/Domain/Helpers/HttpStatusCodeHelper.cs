using Domain.Enums.ErrorCodes;
using System.Net;

namespace Domain.Helper
{
    public static class HttpStatusCodeHelper
    {
        public static int GetHttpStatusCodeByErrorCodeEnum(int code)
        {
            return code switch
            {
                (int)ErrorCodeEnum.UNKNOW_ERROR => (int)HttpStatusCode.InternalServerError,
                (int)ErrorCodeEnum.VALIDATION_ERROR => (int)HttpStatusCode.BadRequest,
                (int)ErrorCodeEnum.RESOURCE_NOT_FOUND => (int)HttpStatusCode.NotFound,
                (int)ErrorCodeEnum.UNAUTHORIZED_ERROR => (int)HttpStatusCode.Unauthorized,
                _ => (int)HttpStatusCode.InternalServerError,
            };
        }
    }
}
