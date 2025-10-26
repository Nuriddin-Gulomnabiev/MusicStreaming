using Domain.Common;
using Domain.Enums.ErrorCodes;

namespace Domain.Exceptions
{
    public class ValidationException : BaseException
    {
        public Dictionary<string, IEnumerable<string>> Errors { get; private set; }
        public override ErrorCodeEnum Code { get => ErrorCodeEnum.VALIDATION_ERROR; }

        public ValidationException(Dictionary<string, IEnumerable<string>> errors) : base("Ошибка валидации")
        {
            Errors = errors;
        }
    }
}
