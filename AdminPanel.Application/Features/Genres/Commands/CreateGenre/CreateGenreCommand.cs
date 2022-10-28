using MediatR;

namespace AdminPanel.Application.Features.Genres.Commands.CreateGenre
{
    public class CreateGenreCommand : IRequest
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
