using AdminPanel.Application.Common.Enums;
using System.Net;

namespace AdminPanel.Web.Common.Utils
{
    public static class HttpStatusCodeUtil
    {
        public static int GetHttpStatusCodeByErrorCodeEnum(int code)
        {
            switch (code)
            {
                case (int)ErrorCodeEnum.UNKNOW_ERROR:
                    return (int)HttpStatusCode.InternalServerError;

                case (int)ErrorCodeEnum.VALIDATION_ERROR:
                    return (int)HttpStatusCode.BadRequest;

                case (int)ErrorCodeEnum.RESOURCE_NOT_FOUND:
                    return (int)HttpStatusCode.NotFound;

                case (int)ErrorCodeEnum.UNAUTHORIZED_ERROR:
                    return (int)HttpStatusCode.Unauthorized;

                default:
                    return (int)HttpStatusCode.InternalServerError;
            }
        }
    }
}
