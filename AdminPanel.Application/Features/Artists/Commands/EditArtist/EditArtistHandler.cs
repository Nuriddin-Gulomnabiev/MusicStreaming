using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Artists.Commands.EditArtist
{
    internal class EditArtistHandler : BaseCommandQueryHandler, IRequestHandler<EditArtistCommand>
    {
        public EditArtistHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(EditArtistCommand request, CancellationToken cancellationToken)
        {
            var artist = await dbContext.Artists.Where(a => a.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Исполнитель не найден");

            artist.Name = request.Name.Trim();
            artist.IsActive = request.IsActive;

            dbContext.Artists.Update(artist);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
