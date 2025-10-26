using FluentValidation;

namespace Client.Application.Features.Identity.Commands.Login
{
    internal class LoginValidator : AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(p => p.Email)
                .NotNull()
                .WithMessage("Введите почту")
                .DependentRules(() =>
                {
                    RuleFor(p => p.Email)
                        .NotEmpty()
                        .EmailAddress()
                        .WithMessage("Введите почту")
                        .DependentRules(() =>
                        {
                            RuleFor(p => p.Email)
                                .EmailAddress()
                                .WithMessage("Неверный формат почты");
                        });
                });

            RuleFor(p => p.Password)
                .NotNull()
                .WithMessage("Введите пароль")
                .DependentRules(() =>
                {
                    RuleFor(p => p.Password)
                        .NotEmpty()
                        .WithMessage("Введите пароль");
                });

            RuleFor(p => p.DeviceId)
                .NotNull()
                .WithMessage("Неверно заполненные данные")
                .DependentRules(() =>
                {
                    RuleFor(p => p.DeviceId)
                        .NotEmpty()
                        .WithMessage("Неверно заполненные данные");
                });
        }
    }
}
