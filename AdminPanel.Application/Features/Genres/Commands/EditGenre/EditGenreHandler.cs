using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Genres.Commands.EditGenre
{
    internal class EditGenreHandler : BaseCommandQueryHandler, IRequestHandler<EditGenreCommand>
    {
        public EditGenreHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(EditGenreCommand request, CancellationToken cancellationToken)
        {
            var genre = await dbContext.Genres.Where(g => g.Id == request.Id && g.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Жанр не найден");

            genre.Name = request.Name;
            genre.IsActive = request.IsActive;

            dbContext.Genres.Update(genre);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
