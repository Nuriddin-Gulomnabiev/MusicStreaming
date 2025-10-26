using FluentValidation;

namespace AdminPanel.Application.Features.Albums.Commands.CreateAlbum
{
    public class CreateAlbumValidator : AbstractValidator<CreateAlbumCommand>
    {
        public CreateAlbumValidator()
        {
            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Введите название альбома");

            RuleFor(p => p.ReleaseDate)
                .NotNull()
                .NotEmpty()
                .WithMessage("Введите дату релиза");

            RuleFor(p => p.ArtistsCodes)
                .NotNull()
                .WithMessage("Заполните список артистов")
                .DependentRules(() =>
                {
                    RuleFor(p => p.ArtistsCodes)
                        .Must(p => p.Any())
                        .WithMessage("Заполните список артистов")
                        .DependentRules(() =>
                        {
                            RuleForEach(p => p.ArtistsCodes)
                                .GreaterThan(0)
                                .WithMessage("Неверный идентификатор Исполнителя");
                        });

                });
        }
    }
}
