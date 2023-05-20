using FluentValidation;

namespace Client.Application.Features.Playlists.Command.MovePlaylistTrack
{
    public class MovePlaylistTrackValidator : AbstractValidator<MovePlaylistTrackCommand>
    {
        public MovePlaylistTrackValidator()
        {
            RuleFor(p => p.FromPosition)
                .NotNull()
                .NotEmpty()
                .WithMessage("Выберите трек");

            RuleFor(p => p.PlaylistCode)
                .NotNull()
                .NotEmpty()
                .WithMessage("Выберите плейлист");

            RuleFor(p => p.ToPosition)
                .NotNull()
                .NotEmpty()
                .WithMessage("Выберите позицию");

            RuleFor(x => x.FromPosition)
                .NotEqual(x => x.ToPosition)
                .WithMessage("FromPosition и ToPosition должны быть разными");
        }
    }
}
