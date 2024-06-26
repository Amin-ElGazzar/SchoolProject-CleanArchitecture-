using MediatR;
using School.Application.Common.Models;
using School.Application.Features.Authentication.Commends.Models.Response;

namespace School.Application.Features.Authentication.Commends.Models.Requests
{
    public class SignInRequest : IRequest<Response<TokenModleResponse>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
