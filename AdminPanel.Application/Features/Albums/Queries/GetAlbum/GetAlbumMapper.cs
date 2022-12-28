using AutoMapper;
using Domain.Entities.Albums;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    internal class GetAlbumMapper : Profile
    {
        public GetAlbumMapper()
        {
            CreateMap<Album, GetAlbumViewModel>()
                .ForMember(vm => vm.Genres, opt => opt.MapFrom(src => src.AlbumGenres.Select(a => a.Genre).ToDictionary(a => a.Code, a => a.Name)))
                .ForMember(vm => vm.Artists, opt => opt.MapFrom(src => src.ArtistAlbums.Select(a => a.Artist).ToDictionary(a => a.Code, a => a.Name)));
        }
    }
}
