namespace Client.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsViewModel
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Dictionary<int, string> Artists { get; set; }
        public int TrackCount { get; set; }
        public decimal Duration { get; set; }
    }
}
