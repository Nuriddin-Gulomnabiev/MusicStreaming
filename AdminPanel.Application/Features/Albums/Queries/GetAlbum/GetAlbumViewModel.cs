namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Dictionary<int, string> Artists { get; set; }
        public Dictionary<int, string> Genres { get; set; }
        public IEnumerable<TrackViewModel> Tracks { get; set; }
    }

    public class TrackViewModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}