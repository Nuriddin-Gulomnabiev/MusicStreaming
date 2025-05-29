using AutoMapper;
using Domain.Entities.Artists;

namespace Client.Application.Features.Artists.Queries.GetAllArtists
{
    class GetAllArtistsMapper : Profile
    {
        public GetAllArtistsMapper()
        {
            CreateMap<Artist, GetAllArtistsViewModel>()
                .ForMember(vm => vm.AlbumCount, opt => opt.MapFrom(src => src.ArtistAlbums.Count));;
        }
    }
}
