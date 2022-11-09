using FileManager.Application.Common.Helpers;
using FluentValidation;

namespace FileManager.Application.Features.Photos.Commands.AddPhoto
{
    public class AddPhotoValidator : AbstractValidator<AddPhotoCommand>
    {
        public AddPhotoValidator(AllowedContentTypes types)
        {
            RuleFor(p => p.PhotoFile)
                .NotNull()
                .WithMessage("Прикрепите фото")
                .DependentRules(() =>
                {
                    RuleFor(p => p.PhotoFile.Length)
                        .Must(length => length > 0)
                        .OverridePropertyName(p => p.PhotoFile)
                        .WithMessage("Фото не должен быть пустым");

                    RuleFor(p => p)
                        .Must(command => types.Photo.Contains(command.PhotoFile.ContentType))
                        .OverridePropertyName(p => p.PhotoFile)
                        .WithMessage("Данный формат фотографии не поддерживается");
                });
        }
    }
}
