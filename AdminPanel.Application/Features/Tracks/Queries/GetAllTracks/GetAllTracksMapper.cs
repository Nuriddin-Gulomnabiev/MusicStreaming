using AutoMapper;
using Domain.Entities.Tracks;

namespace AdminPanel.Application.Features.Tracks.Queries.GetAllTracks
{
    public class GetAllTracksMapper : Profile
    {
        public GetAllTracksMapper()
        {
            CreateMap<Track, GetAllTracksViewModel>()
                .ForMember(vm => vm.Artists, opt => opt.MapFrom(src => src.ArtistTracks.Select(a => a.Artist).ToDictionary(a => a.Code, a => a.Name)));
        }
    }
}
