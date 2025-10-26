using FluentValidation;

namespace AdminPanel.Application.Features.Artists.Commands.EditArtist
{
    public class EditArtistValidator : AbstractValidator<EditArtistCommand>
    {
        public EditArtistValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Заполните имя Исполнителя");
        }
    }
}
