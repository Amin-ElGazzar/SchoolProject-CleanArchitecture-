using MediatR;
using School.Application.Common.Models;
using School.Application.Features.Authentication.Commends.ViewModel;
using System.Security.Claims;

namespace School.Application.Features.Authentication.Commends.Models.Requests
{
    public class ChangePasswordRequest : IRequest<Response<string>>
    {
        public ChangePasswordViewModel Model { get; private set; }
        public ClaimsPrincipal User { get; private set; }

        public ChangePasswordRequest(ChangePasswordViewModel model, ClaimsPrincipal user)
        {
            Model = model;
            User = user;
        }
    }
}
