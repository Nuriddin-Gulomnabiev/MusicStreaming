using AutoMapper;
using Domain.Entities.Playlists;

namespace Client.Application.Features.Playlists.Query.GetPlaylist
{
    public class GetPlaylistMapper : Profile
    {
        public GetPlaylistMapper()
        {
            CreateMap<Playlist, GetPlaylistViewModel>();
        }
    }
}
