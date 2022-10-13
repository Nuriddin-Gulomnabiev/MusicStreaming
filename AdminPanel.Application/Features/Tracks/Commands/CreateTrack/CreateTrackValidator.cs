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
        }
    }
}
