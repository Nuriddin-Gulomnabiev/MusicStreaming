using Domain.Common;
using Domain.Enums.ErrorCodes;

namespace Domain.Exceptions
{
    public class UnauthorizedException : BaseException
    {
        public override ErrorCodeEnum Code => ErrorCodeEnum.UNAUTHORIZED_ERROR;

        public UnauthorizedException() : base("Ошибка авторизации")
        {
        }

        public UnauthorizedException(string message) : base(message)
        {
        }
    }
}
