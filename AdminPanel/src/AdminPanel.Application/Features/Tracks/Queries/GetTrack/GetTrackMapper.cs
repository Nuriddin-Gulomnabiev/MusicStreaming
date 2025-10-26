using AutoMapper;
using Domain.Entities.Tracks;

namespace AdminPanel.Application.Features.Tracks.Queries.GetTrack
{
    public class GetTrackMapper : Profile
    {
        public GetTrackMapper()
        {
            CreateMap<Track, GetTrackViewModel>()
                .ForMember(vm => vm.Artists, opt => opt.MapFrom(src => src.ArtistTracks.Select(a => a.Artist).ToDictionary(a => a.Code, a => a.Name)));
        }
    }
}
