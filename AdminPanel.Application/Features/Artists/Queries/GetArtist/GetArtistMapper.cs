using AutoMapper;
using Domain.Entities.Artists;

namespace AdminPanel.Application.Features.Artists.Queries.GetArtist
{
    internal class GetArtistMapper : Profile
    {
        public GetArtistMapper()
        {
            CreateMap<Artist, GetArtistViewModel>();
        }
    }
}
