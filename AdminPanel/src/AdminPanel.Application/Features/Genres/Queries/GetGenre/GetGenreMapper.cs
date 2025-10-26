using AutoMapper;
using Domain.Entities.Genres;

namespace AdminPanel.Application.Features.Genres.Queries.GetGenre
{
    internal class GetGenreMapper : Profile
    {
        public GetGenreMapper()
        {
            CreateMap<Genre, GetGenreViewModel>();
        }
    }
}
