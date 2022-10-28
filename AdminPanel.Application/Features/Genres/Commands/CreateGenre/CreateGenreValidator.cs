using AdminPanel.Application.Common.Interfaces;
using FluentValidation;

namespace AdminPanel.Application.Features.Genres.Commands.CreateGenre
{
    public class CreateGenreValidator : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreValidator(IAdminApplicationDbContext dbContext)
        {
            RuleFor(p => p.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Введите название жанра")
                .DependentRules(() =>
                {
                    RuleFor(p => p.Name)
                        .Must(p => dbContext.Genres.Where(g => g.Name == p).FirstOrDefault() == null)
                        .WithMessage("Такое название жанра уже имеется");
                });
        }
    }
}
