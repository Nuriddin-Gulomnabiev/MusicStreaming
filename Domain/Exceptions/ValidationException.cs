using Domain.Common;
using Domain.Enums.ErrorCodes;

namespace Domain.Exceptions
{
    public class ValidationException : BaseException
    {
        public IEnumerable<ValidationError> Errors { get; private set; }
        public override ErrorCodeEnum Code { get => ErrorCodeEnum.VALIDATION_ERROR; }

        public ValidationException(IEnumerable<ValidationError> errors) : base("Ошибка валидации")
        {
            Errors = errors;
        }
    }

    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
