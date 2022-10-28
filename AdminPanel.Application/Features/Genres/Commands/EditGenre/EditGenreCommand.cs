using MediatR;

namespace AdminPanel.Application.Features.Genres.Commands.EditGenre
{
    public class EditGenreCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
