using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Tracks.Commands.EditTrackStatus
{
    internal class EditTrackStatusHandler : BaseCommandQueryHandler, IRequestHandler<EditTrackStatusCommand, Unit>
    {
        public EditTrackStatusHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(EditTrackStatusCommand request, CancellationToken cancellationToken)
        {
            var track = await dbContext.Tracks.Where(t => t.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Трек не найден");

            if (track.IsActive == request.Status)
                return Unit.Value;

            track.IsActive = request.Status;

            dbContext.Tracks.Update(track);
            await dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
