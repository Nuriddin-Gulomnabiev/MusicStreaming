using AdminPanel.Application.Common.Enums;
using FluentValidation.Results;

namespace AdminPanel.Application.Common.Exceptions
{
    public class ValidationException : BaseException
    {
        public IEnumerable<ValidationFailure> Errors { get; private set; }
        public override ErrorCodeEnum Code { get => ErrorCodeEnum.VALIDATION_ERROR; }

        public ValidationException(IEnumerable<ValidationFailure> failures) : base("Ошибка валидации")
        {
            Errors = failures;
        }
    }
}
