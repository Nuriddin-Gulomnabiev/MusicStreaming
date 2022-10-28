using MediatR;

namespace AdminPanel.Application.Features.Albums.Commands.EditAlbum
{
    public class EditAlbumCommand : IRequest
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IEnumerable<int> ArtistsCodes { get; set; }
        public IEnumerable<int> GenresCodes { get; set; }
    }
}
