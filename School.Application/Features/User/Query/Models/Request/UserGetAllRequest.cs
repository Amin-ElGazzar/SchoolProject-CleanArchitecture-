using MediatR;
using School.Application.Common.Models;
using School.Application.Features.User.Query.Models.responses;

namespace School.Application.Features.User.Query.Models.Request
{
    public class UserGetAllRequest : IRequest<Response<IEnumerable<UserGetAllResponse>>>
    {
    }
}
