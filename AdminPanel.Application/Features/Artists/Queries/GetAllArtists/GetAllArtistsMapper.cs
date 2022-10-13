using AutoMapper;
using Domain.Entities.Artists;

namespace AdminPanel.Application.Features.Artists.Queries.GetAllArtists
{
    internal class GetAllArtistsMapper : Profile
    {
        public GetAllArtistsMapper()
        {
            CreateMap<Artist, GetAllArtistsViewModel>();
        }
    }
}
