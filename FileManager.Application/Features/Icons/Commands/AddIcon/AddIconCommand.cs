using MediatR;
using Microsoft.AspNetCore.Http;

namespace FileManager.Application.Features.Icons.Commands.AddIcon
{
    public class AddIconCommand : IRequest
    {
        public IFormFile IconFile { get; }

        public AddIconCommand(IFormFile icon)
        {
            IconFile = icon;
        }
    }
}
