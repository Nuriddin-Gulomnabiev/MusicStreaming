using MediatR;

namespace AdminPanel.Application.Features.Albums.Commands.CreateAlbum
{
    public class CreateAlbumCommand : IRequest
    {
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IEnumerable<int> ArtistsCodes { get; set; }
        public IEnumerable<int> GenresCodes { get; set; }
    }
}
