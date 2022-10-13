using FluentValidation;

namespace AdminPanel.Application.Features.Artists.Queries.GetArtist
{
    public class GetArtistValidator : AbstractValidator<GetArtistQuery>
    {
        public GetArtistValidator()
        {
            RuleFor(p => p.Code)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
        }
    }
}
