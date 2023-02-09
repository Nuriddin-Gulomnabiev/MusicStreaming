using AutoMapper;
using Domain.Entities.Albums;

namespace AdminPanel.Application.Features.Albums.Queries.GetAllAlbums
{
    internal class GetAllAlbumsMapper : Profile
    {
        public GetAllAlbumsMapper()
        {
            CreateMap<Album, GetAllAlbumsViewModel>()
                .ForMember(vm => vm.Artists, opt => opt.MapFrom(src => src.ArtistAlbums.Select(a => a.Artist).ToDictionary(a => a.Code, a => a.Name)))
                .ForMember(vm => vm.Genres, opt => opt.MapFrom(src => src.AlbumGenres.Select(g => g.Genre).ToDictionary(g => g.Code, a => a.Name)));
        }
    }
}
