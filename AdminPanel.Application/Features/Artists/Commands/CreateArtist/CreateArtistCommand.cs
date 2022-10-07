using Domain.Entities.Artists;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistCommand : IRequest<Artist>
    {
        public string Name { get; set; }
    }
}
