using MediatR;

namespace FileManager.Application.Features.Tracks.Queries.GetTrack
{
    public class GetTrackQuery : IRequest<Stream>
    {
        public int Code { get; set; }

        public GetTrackQuery(int code)
        {
            Code = code;
        }
    }
}
