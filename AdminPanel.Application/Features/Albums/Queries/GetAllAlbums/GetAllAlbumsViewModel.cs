namespace AdminPanel.Application.Features.Albums.Queries.GetAllAlbums
{
    internal class GetAllAlbumsViewModel
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Dictionary<int, string> Artists { get; set; }
        public Dictionary<int, string> Genres { get; set; }
    }
}
