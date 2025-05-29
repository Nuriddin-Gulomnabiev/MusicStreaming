using AutoMapper;
using Client.Application.Features.Artists.Queries;
using Domain.Entities.Albums;
using Domain.Entities.Artists;

namespace Client.Application.Features.Albums.Queries.GetAllAlbums
{
    class GetAllAlbumsMapper : Profile
    {
        public GetAllAlbumsMapper()
        {
            CreateMap<Album, GetAllAlbumsViewModel>()
                .ForMember(dest => dest.Cover, opt => opt.MapFrom(src => src.CoverUrl))
                .ForMember(dest => dest.Artists, opt => opt.Ignore())
                .ForMember(dest => dest.TrackCount, opt => opt.Ignore())
                .ForMember(dest => dest.Duration, opt => opt.Ignore());
        }
    }
}
