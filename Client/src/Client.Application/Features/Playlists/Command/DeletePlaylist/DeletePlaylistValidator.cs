using FluentValidation;

namespace Client.Application.Features.Playlists.Command.DeletePlaylist
{
    public class DeletePlaylistValidator : AbstractValidator<DeletePlaylistCommand>
    {
        public DeletePlaylistValidator()
        {
            RuleFor(p => p.PlaylistCode)
                .NotNull()
                .NotEmpty()
                .WithMessage("Введите идентификатор плейлиста")
                .DependentRules(() =>
                {
                    RuleFor(p => p.PlaylistCode)
                        .GreaterThan(0)
                        .WithMessage("Введите идентификатор плейлиста");
                });
        }
    }
}
