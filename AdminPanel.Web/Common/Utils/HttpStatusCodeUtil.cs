using Domain.Enums.ErrorCodes;
using System.Net;

namespace AdminPanel.Web.Common.Utils
{
    public static class HttpStatusCodeUtil
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
