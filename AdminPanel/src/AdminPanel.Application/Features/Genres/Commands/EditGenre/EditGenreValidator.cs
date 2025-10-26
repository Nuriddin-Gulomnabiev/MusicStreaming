using AdminPanel.Application.Common.Interfaces;
using FluentValidation;

namespace AdminPanel.Application.Features.Genres.Commands.EditGenre
{
    public class EditGenreValidator : AbstractValidator<EditGenreCommand>
    {
        public EditGenreValidator(IAdminApplicationDbContext dbContext)
        {
            RuleFor(p => p.Name)
                .Must(p => !string.IsNullOrEmpty(p))
                .WithMessage("Введите название жанра")
                .DependentRules(() =>
                {
                    RuleFor(p => p.Id)
                        .NotNull()
                        .WithMessage("Введите ID жанра")
                        .DependentRules(() =>
                        {
                            RuleFor(p => p)
                                .Must(c => dbContext.Genres.Where(g => g.Name == c.Name && g.Id != c.Id).FirstOrDefault() == null)
                                .OverridePropertyName(p => p.Name)
                                .WithMessage("Такое название жанра уже имеется");
                        });
                });
        }
    }
}
