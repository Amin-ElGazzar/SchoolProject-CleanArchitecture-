using MediatR;
using School.Application.Common.Models;
using School.Application.Features.User.Query.Models.responses;

namespace School.Application.Features.User.Query.Models.Request
{
    public class UserGetByIdRequest : IRequest<Response<UserGetAllResponse>>
    {
        public string Id { get; set; }
    }
}
