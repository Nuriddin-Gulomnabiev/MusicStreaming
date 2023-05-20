using FluentValidation;

namespace Client.Application.Features.Playlists.Command.DeletePlaylistTrack
{
    public class DeletePlaylistTrackValidator : AbstractValidator<DeletePlaylistTrackCommand>
    {
        public DeletePlaylistTrackValidator()
        {
            RuleFor(p => p.Position)
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
