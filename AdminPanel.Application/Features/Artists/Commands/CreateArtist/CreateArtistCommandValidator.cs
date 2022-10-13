using FluentValidation;

namespace AdminPanel.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistCommandValidator : AbstractValidator<CreateArtistCommand>
    {
        public CreateArtistCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull();
        }
    }
}
