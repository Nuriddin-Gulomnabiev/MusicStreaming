namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumViewModel
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public Dictionary<int, string> Artists { get; set; }
        public Dictionary<int, string> Tracks { get; set; }
    }
}