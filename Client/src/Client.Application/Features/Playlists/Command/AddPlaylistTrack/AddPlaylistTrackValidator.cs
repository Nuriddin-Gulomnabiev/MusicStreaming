using FluentValidation;

namespace Client.Application.Features.Playlists.Command.AddPlaylistTrack
{
    public class AddPlaylistTrackValidator : AbstractValidator<AddPlaylistTrackCommand>
    {
        public AddPlaylistTrackValidator()
        {
            RuleFor(p => p.TrackCode)
                .NotNull()
                .NotEmpty()
                .WithMessage("Выберите трек");

            RuleFor(p => p.PlaylistCode)
                .NotNull()
                .NotEmpty()
                .WithMessage("Выберите плейлист");
        }
    }
}
