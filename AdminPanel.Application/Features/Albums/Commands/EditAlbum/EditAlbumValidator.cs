using FluentValidation;

namespace AdminPanel.Application.Features.Albums.Commands.EditAlbum
{
    public class EditAlbumValidator : AbstractValidator<EditAlbumCommand>
    {
        public EditAlbumValidator()
        {
            RuleFor(p => p.Id)
                .NotNull()
                .NotEmpty();

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

            RuleFor(p => p.GenresCodes)
                .NotNull()
                .WithMessage("Заполните список жанров")
                .DependentRules(() =>
                {
                    RuleFor(p => p.GenresCodes)
                        .Must(p => p.Any())
                        .WithMessage("Заполните список жанров")
                        .DependentRules(() =>
                        {
                            RuleForEach(p => p.GenresCodes)
                                .GreaterThan(0)
                                .WithMessage("Неверный идентификатор Жанра");
                        });

                });
        }
    }
}
