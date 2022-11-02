using Domain.Common;
using Domain.Enums.ErrorCodes;

namespace Services.Services.JwtService.Exceptions
{
    public class TokenExpiredException : BaseException
    {
        public override ErrorCodeEnum Code => ErrorCodeEnum.UNAUTHORIZED_ERROR;

        public TokenExpiredException() : base("Срок токена истек")
        {
        }
    }
}
