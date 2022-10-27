using FluentValidation;

namespace AdminPanel.Application.Features.Tracks.Commands.EditTrack
{
    public class EditTrackValidator : AbstractValidator<EditTrackCommand>
    {
        public EditTrackValidator()
        {
            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty();

            RuleFor(p => p.AlbumCode)
                .NotNull()
                .GreaterThan(0);

            RuleFor(p => p.ArtistsCodes)
                .NotNull();

            RuleForEach(p => p.ArtistsCodes)
                .NotNull()
                .GreaterThan(0);

            RuleFor(p => p.Track)
                .NotNull()
                .WithMessage("Прикрепите аудио")
                .DependentRules(() =>
                {
                    RuleFor(p => p.Track.ContentType)
                        .Must(p => p.Equals("audio/mpeg"))
                        .OverridePropertyName(p => p.Track)
                        .WithMessage("Неверный формат аудиофайла. Пожалуйста прикрепите mp3 файл");
                })
                .When(p => p.IsTrackReloaded);
        }
    }
}
