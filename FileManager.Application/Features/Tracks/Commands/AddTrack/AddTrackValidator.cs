using FileManager.Application.Common.Helpers;
using FluentValidation;

namespace FileManager.Application.Features.Tracks.Commands.AddTrack
{
    public class AddTrackValidator : AbstractValidator<AddTrackCommand>
    {
        public AddTrackValidator(AllowedContentTypes types)
        {
            RuleFor(p => p.TrackFile)
                .NotNull()
                .WithMessage("Прикрепите аудио файл")
                .DependentRules(() =>
                {
                    RuleFor(p => p.TrackFile.Length)
                        .Must(length => length > 0)
                        .OverridePropertyName(p => p.TrackFile)
                        .WithMessage("Файл не должен быть пустым");

                    RuleFor(p => p.TrackFile.ContentType)
                        .Must(contentType => types.Audio.Contains(contentType))
                        .OverridePropertyName(p => p.TrackFile)
                        .WithMessage("Данный формат аудио не поддерживается");
                });
        }
    }
}
