using AutoMapper;
using Domain.Entities.Albums;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    internal class GetAlbumMapper : Profile
    {
        public GetAlbumMapper()
        {
            CreateMap<Album, GetAlbumViewModel>()
                .ForMember(vm => vm.Tracks, opt => opt.MapFrom(src => src.Tracks.ToDictionary(t => t.Code, t => t.Name)));
        }
    }
}
