using FileManager.Application.Common.Helpers;
using FluentValidation;

namespace FileManager.Application.Features.Covers.Commands.AddCover
{
    public class AddCoverValidator : AbstractValidator<AddCoverCommand>
    {
        public AddCoverValidator(AllowedContentTypes types)
        {
            RuleFor(p => p.CoverFile)
                .NotNull()
                .WithMessage("Прикрепите иконку")
                .DependentRules(() =>
                {
                    RuleFor(p => p.CoverFile.Length)
                        .Must(length => length > 0)
                        .OverridePropertyName(p => p.CoverFile)
                        .WithMessage("Иконка не должена быть пустой");

                    RuleFor(p => p)
                        .Must(command => types.Cover.Contains(command.CoverFile.ContentType))
                        .OverridePropertyName(p => p.CoverFile)
                        .WithMessage("Данный формат иконки не поддерживается");
                });
        }
    }
}
