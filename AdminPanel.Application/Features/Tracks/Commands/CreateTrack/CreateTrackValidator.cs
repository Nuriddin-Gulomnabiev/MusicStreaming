using FluentValidation;

namespace AdminPanel.Application.Features.Tracks.Commands.CreateTrack
{
    public class CreateTrackValidator : AbstractValidator<CreateTrackCommand>
    {
        public CreateTrackValidator()
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
                .WithMessage("Прикрепите аудио");

            RuleFor(p => p.Track.ContentType)
                .Must(c => c.Equals("audio/mpeg"))
                .WithMessage("Неверный формат аудиофайла. Пожалуйста прикрепите mp3 файл");
        }
    }
}
