using AutoMapper;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Tracks;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    internal class GetAlbumMapper : Profile
    {
        public GetAlbumMapper()
        {
            CreateMap<Track, GetAlbumViewModel.CollectionViewModel>();
            CreateMap<Genre, GetAlbumViewModel.CollectionViewModel>();
            CreateMap<Artist, GetAlbumViewModel.CollectionViewModel>();
            CreateMap<Album, GetAlbumViewModel>()
                .ForMember(vm => vm.Genres, opt => opt.MapFrom(src => src.AlbumGenres.Select(a => a.Genre)))
                .ForMember(vm => vm.Artists, opt => opt.MapFrom(src => src.ArtistAlbums.Select(a => a.Artist)));
        }
    }
}
