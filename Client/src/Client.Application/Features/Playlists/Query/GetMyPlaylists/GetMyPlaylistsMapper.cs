using AutoMapper;
using Domain.Entities.Playlists;

namespace Client.Application.Features.Playlists.Query.GetMyPlaylists
{
    internal class GetMyPlaylistsMapper : Profile
    {
        public GetMyPlaylistsMapper()
        {
            CreateMap<Playlist, GetMyPlaylistsViewModel>();
        }
    }
}
