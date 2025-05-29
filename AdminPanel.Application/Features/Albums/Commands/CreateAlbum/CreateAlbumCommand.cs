using MediatR;

namespace AdminPanel.Application.Features.Albums.Commands.CreateAlbum
{
    public class CreateAlbumCommand : IRequest<int>
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IEnumerable<int> ArtistsCodes { get; set; }
    }
}
