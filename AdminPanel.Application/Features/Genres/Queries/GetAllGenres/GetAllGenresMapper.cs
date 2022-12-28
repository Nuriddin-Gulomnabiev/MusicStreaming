using AutoMapper;
using Domain.Entities.Genres;

namespace AdminPanel.Application.Features.Genres.Queries.GetAllGenres
{
    public class GetAllGenresMapper : Profile
    {
        public GetAllGenresMapper()
        {
            CreateMap<Genre, GetAllGenresViewModel>();
        }
    }
}
