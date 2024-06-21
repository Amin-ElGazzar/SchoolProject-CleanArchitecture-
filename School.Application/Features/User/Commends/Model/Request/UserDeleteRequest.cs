using MediatR;
using School.Application.Common.Models;

namespace School.Application.Features.User.Commends.Model.Request
{
    public class UserDeleteRequest : IRequest<Response<string>>
    {
        public string UserId { get; set; }
    }
}
