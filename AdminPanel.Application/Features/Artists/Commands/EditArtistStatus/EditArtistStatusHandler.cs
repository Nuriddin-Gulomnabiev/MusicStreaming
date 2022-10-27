using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Artists.Commands.EditArtistStatus
{
    internal class EditArtistStatusHandler : BaseCommandQueryHandler, IRequestHandler<EditArtistStatusCommand, bool>
    {
        public EditArtistStatusHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<bool> Handle(EditArtistStatusCommand request, CancellationToken cancellationToken)
        {
            var artist = await dbContext.Artists.Where(t => t.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Трек не найден");

            if (artist.IsActive == request.Status)
                return true;

            artist.IsActive = request.Status;

            dbContext.Artists.Update(artist);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
