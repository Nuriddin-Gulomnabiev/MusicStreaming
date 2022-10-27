using MediatR;

namespace AdminPanel.Application.Features.Tracks.Queries.GetTrack
{
    public class GetTrackQuery : IRequest<GetTrackViewModel>
    {
        public int Code { get; }

        public GetTrackQuery(int code)
        {
            Code = code;
        }
    }
}
