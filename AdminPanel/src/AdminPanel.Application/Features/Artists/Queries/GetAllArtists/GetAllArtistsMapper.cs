using AutoMapper;
using Domain.Entities.Artists;

namespace AdminPanel.Application.Features.Artists.Queries.GetAllArtists
{
    internal class GetAllArtistsMapper : Profile
    {
        public GetAllArtistsMapper()
        {
            CreateMap<Artist, GetAllArtistsViewModel>()
                .ForMember(vm => vm.Albums, opt => opt.MapFrom(src => src.ArtistAlbums.Select(a => a.Album).ToDictionary(a => a.Code, a => a.Name)));
        }
    }
}
