using AutoMapper;
using Domain.Entities.Tracks;

namespace AdminPanel.Application.Features.Tracks.Queries.GetTrack
{
    public class GetTrackMapper : Profile
    {
        public GetTrackMapper()
        {
            CreateMap<Track, GetTrackViewModel>();
        }
    }
}
