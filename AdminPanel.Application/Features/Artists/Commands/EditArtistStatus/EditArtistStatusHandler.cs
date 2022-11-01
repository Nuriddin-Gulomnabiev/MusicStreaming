using Domain.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Artists.Commands.EditArtistStatus
{
    internal class EditArtistStatusHandler : BaseCommandQueryHandler, IRequestHandler<EditArtistStatusCommand>
    {
        public EditArtistStatusHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(EditArtistStatusCommand request, CancellationToken cancellationToken)
        {
            var artist = await dbContext.Artists.Where(t => t.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Трек не найден");

            if (artist.IsActive == request.Status)
                return Unit.Value;

            artist.IsActive = request.Status;

            dbContext.Artists.Update(artist);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
