using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Application.Features.Artists.Queries.GetAllArtists
{
    public class GetAllArtistsQuery : IRequest<List<GetAllArtistsViewModel>>
    {
    }
}
