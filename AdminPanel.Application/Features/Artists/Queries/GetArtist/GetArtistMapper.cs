using AutoMapper;
using Domain.Entities.Artists;

namespace AdminPanel.Application.Features.Artists.Queries.GetArtist
{
    internal class GetArtistMapper : Profile
    {
        public GetArtistMapper()
        {
            CreateMap<Artist, GetArtistViewModel>()
                .ForMember(vm => vm.Albums, opt => opt.MapFrom(src => src.ArtistAlbums.Select(a => a.Album).ToDictionary(a => a.Code, a => a.Name)));
        }
    }
}
