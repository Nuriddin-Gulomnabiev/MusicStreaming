using Domain.Enums.ErrorCodes;
using Domain.Exceptions;

namespace Services.Services.JwtService.Exceptions
{
    public class TokenInvalidException : BaseException
    {
        public override ErrorCodeEnum Code => ErrorCodeEnum.UNAUTHORIZED_ERROR;

        public TokenInvalidException() : base("Неверный формат токена")
        {
        }
    }
}
