namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumViewModel
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public Dictionary<int, string> Artists { get; set; }
        public IEnumerable<TrackViewModel> Tracks { get; set; }
    }

    public class TrackViewModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
    }
}