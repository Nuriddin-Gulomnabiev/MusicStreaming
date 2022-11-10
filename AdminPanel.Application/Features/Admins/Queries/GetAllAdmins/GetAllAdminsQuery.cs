using MediatR;

namespace AdminPanel.Application.Features.Admins.Queries.GetAllAdmins
{
    public class GetAllAdminsQuery : IRequest<List<GetAllAdminsViewModel>>
    {
    }
}
