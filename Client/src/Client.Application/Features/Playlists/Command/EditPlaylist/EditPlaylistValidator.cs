using FluentValidation;

namespace Client.Application.Features.Playlists.Command.EditPlaylist
{
    public class EditPlaylistValidator : AbstractValidator<EditPlaylistCommand>
    {
        public EditPlaylistValidator()
        {
            RuleFor(p => p.Title)
                .NotEqual(string.Empty)
                .WithMessage("Введите название плейлиста");

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
