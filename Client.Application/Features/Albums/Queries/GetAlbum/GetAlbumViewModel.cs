namespace Client.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumViewModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Dictionary<int, string> Artists { get; set; }
        public int TrackCount { get; set; }
        public decimal Duration { get; set; }
        public List<TrackViewModel> Tracks { get; set; } = new List<TrackViewModel>();

    }

    public class TrackViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Duration { get; set; }
        public Dictionary<int, string> Genres { get; set; }
        public Dictionary<int, string> Artists { get; set; }
    }
}
