using FluentValidation;

namespace AdminPanel.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistValidator : AbstractValidator<CreateArtistCommand>
    {
        public CreateArtistValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull();
        }
    }
}
