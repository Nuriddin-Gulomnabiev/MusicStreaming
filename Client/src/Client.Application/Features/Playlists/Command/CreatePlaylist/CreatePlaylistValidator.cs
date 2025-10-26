using FluentValidation;

namespace Client.Application.Features.Playlists.Command.CreatePlaylist
{
    public class CreatePlaylistValidator : AbstractValidator<CreatePlaylistCommand>
    {
        public CreatePlaylistValidator()
        {
            RuleFor(p => p.Title)
                .NotNull()
                .NotEmpty()
                .WithMessage("Введите название плейлиста");
        }
    }
}
