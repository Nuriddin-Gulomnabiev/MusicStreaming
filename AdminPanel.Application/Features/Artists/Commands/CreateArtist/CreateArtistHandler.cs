using AdminPanel.Application.Common.Interfaces;
using Domain.Entities.Artists;
using MediatR;

namespace AdminPanel.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistHandler : IRequestHandler<CreateArtistCommand, Artist>
    {
        private readonly IAdminApplicationDbContext dbContext;

        public CreateArtistHandler(IAdminApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Artist> Handle(CreateArtistCommand request, CancellationToken cancellationToken)
        {
            var artist = new Artist() { Name = request.Name };

            await dbContext.Artists.AddAsync(artist, cancellationToken);

            await dbContext.SaveChangesAsync(cancellationToken);

            return artist;
        }
    }
}
