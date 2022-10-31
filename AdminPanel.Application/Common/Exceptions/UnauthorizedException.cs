using AdminPanel.Application.Common.Enums;

namespace AdminPanel.Application.Common.Exceptions
{
    public class UnauthorizedException : BaseException
    {
        public override ErrorCodeEnum Code => ErrorCodeEnum.UNAUTHORIZED_ERROR;

        public UnauthorizedException(string message) : base(message)
        {
        }
    }
}
