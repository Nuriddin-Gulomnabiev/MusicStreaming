using AutoMapper;
using Domain.Entities.Albums;
using Domain.Entities.Tracks;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    internal class GetAlbumMapper : Profile
    {
        public GetAlbumMapper()
        {
            CreateMap<Album, GetAlbumViewModel>();
            CreateMap<Track, TrackViewModel>();
        }
    }
}
