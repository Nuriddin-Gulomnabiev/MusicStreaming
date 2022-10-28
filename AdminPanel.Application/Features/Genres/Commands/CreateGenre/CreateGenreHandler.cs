using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Genres;
using MediatR;

namespace AdminPanel.Application.Features.Genres.Commands.CreateGenre
{
    internal class CreateGenreHandler : BaseCommandQueryHandler, IRequestHandler<CreateGenreCommand>
    {
        public CreateGenreHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(CreateGenreCommand request, CancellationToken cancellationToken)
        {
            dbContext.Genres.Add(new Genre() 
            { 
                Id = Guid.NewGuid(),
                Name = request.Name,
                IsActive = request.IsActive
            });

            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
