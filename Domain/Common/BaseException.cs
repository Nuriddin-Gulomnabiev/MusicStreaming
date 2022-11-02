using Domain.Enums.ErrorCodes;

namespace Domain.Common
{
    public abstract class BaseException : Exception
    {
        public abstract ErrorCodeEnum Code { get; }

        public BaseException(string message) : base(message)
        {
        }
    }
}
