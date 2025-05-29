using AutoMapper;
using Domain.Entities.Albums;

namespace Client.Application.Features.Albums.Queries.GetAlbum
{
    class GetAlbumMapper : Profile
    {
        public GetAlbumMapper()
        {
            CreateMap<Album, GetAlbumViewModel>()
                .ForMember(dest => dest.Cover, opt => opt.MapFrom(src => src.CoverUrl))
                .ForMember(dest => dest.Artists, opt => opt.Ignore())
                .ForMember(dest => dest.TrackCount, opt => opt.Ignore())
                .ForMember(dest => dest.Duration, opt => opt.Ignore());
        }
    }
}
