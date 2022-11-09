using FileManager.Application.Common.Helpers;
using FluentValidation;

namespace FileManager.Application.Features.Icons.Commands.AddIcon
{
    public class AddIconValidator : AbstractValidator<AddIconCommand>
    {
        public AddIconValidator(AllowedContentTypes types)
        {
            RuleFor(p => p.IconFile)
                .NotNull()
                .WithMessage("Прикрепите иконку")
                .DependentRules(() =>
                {
                    RuleFor(p => p.IconFile.Length)
                        .Must(length => length > 0)
                        .OverridePropertyName(p => p.IconFile)
                        .WithMessage("Иконка не должена быть пустой");

                    RuleFor(p => p)
                        .Must(command => types.Icon.Contains(command.IconFile.ContentType))
                        .OverridePropertyName(p => p.IconFile)
                        .WithMessage("Данный формат иконки не поддерживается");
                });
        }
    }
}
