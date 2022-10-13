using FluentValidation;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumValidator : AbstractValidator<GetAlbumQuery>
    {
        public GetAlbumValidator()
        {
            RuleFor(p => p.Code)
                .NotEmpty()
                .GreaterThan(0);
        }
    }
}
