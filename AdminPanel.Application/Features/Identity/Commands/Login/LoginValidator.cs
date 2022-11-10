using FluentValidation;

namespace AdminPanel.Application.Features.Identity.Commands.Login
{
    public class LoginValidator : AbstractValidator<LoginCommand>
    {
        public LoginValidator()
        {
            RuleFor(p => p.Login)
                .NotNull()
                .WithMessage("Введите логин")
                .DependentRules(() =>
                {
                    RuleFor(p => p.Login)
                        .NotEmpty()
                        .WithMessage("Введите логин");
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
        }
    }
}
