namespace AdminPanel.Application.Features.Artists.Queries.GetAllArtists
{
    public class GetAllArtistsViewModel
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }

        public Dictionary<int, string> Albums { get; set; }
    }
}
