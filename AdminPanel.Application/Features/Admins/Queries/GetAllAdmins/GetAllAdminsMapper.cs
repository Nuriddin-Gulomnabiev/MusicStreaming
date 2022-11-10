using AutoMapper;
using Domain.Entities.Admins;

namespace AdminPanel.Application.Features.Admins.Queries.GetAllAdmins
{
    internal class GetAllAdminsMapper : Profile
    {
        public GetAllAdminsMapper()
        {
            CreateMap<Admin, GetAllAdminsViewModel>();
        }
    }
}
