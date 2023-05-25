namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public DateTime ReleaseDate { get; set; }
        public IEnumerable<CollectionViewModel> Artists { get; set; }
        public IEnumerable<CollectionViewModel> Genres { get; set; }
        public IEnumerable<CollectionViewModel> Tracks { get; set; }
        
        public class CollectionViewModel
        {
            public int Code { get; set; }
            public string Name { get; set; }
        }
    }

}