using FileManager.Application.Common.Helpers;
using FluentValidation;

namespace FileManager.Application.Features.Images.Commands.AddImage
{
    public class AddImageValidator : AbstractValidator<AddImageCommand>
    {
        public AddImageValidator(AllowedContentTypes types)
        {
            RuleFor(p => p.ImageFile)
                .NotNull()
                .WithMessage("Прикрепите изображение")
                .DependentRules(() =>
                {
                    RuleFor(p => p.ImageFile.Length)
                        .Must(length => length > 0)
                        .OverridePropertyName(p => p.ImageFile)
                        .WithMessage("Файл не должен быть пустым");

                    RuleFor(p => p)
                        .Must(command => types.IsImageAllowed(command.ImageType, command.ImageFile.ContentType))
                        .OverridePropertyName(p => p.ImageFile)
                        .WithMessage("Данный формат изображения не поддерживается");
                });
        }
    }
}
