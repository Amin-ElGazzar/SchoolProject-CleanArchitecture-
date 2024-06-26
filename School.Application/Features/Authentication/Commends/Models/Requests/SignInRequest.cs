using MediatR;
using School.Application.Features.Authentication.Commends.Models.Response;

namespace School.Application.Features.Authentication.Commends.Models.Requests
{
    public class SignInRequest : IRequest<TokenModleResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
