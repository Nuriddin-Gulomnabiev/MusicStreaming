using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Application.Features.Identity.Commands.Register
{
    internal class RegisterValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterValidator()
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
