using MediatR;
using Microsoft.AspNetCore.Http;

namespace FileManager.Application.Features.Covers.Commands.AddCover
{
    public class AddCoverCommand : IRequest
    {
        public IFormFile CoverFile { get; }

        public AddCoverCommand(IFormFile icon)
        {
            CoverFile = icon;
        }
    }
}
