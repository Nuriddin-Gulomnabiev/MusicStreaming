using AdminPanel.Application.Common.Enums;

namespace AdminPanel.Application.Common.Exceptions
{
    public abstract class BaseException: Exception
    {
        public abstract ErrorCodeEnum Code { get; }

        public BaseException(string message) : base(message)
        {
        }
    }
}
