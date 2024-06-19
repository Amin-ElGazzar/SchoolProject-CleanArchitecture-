using School.Application.Common.Models;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Domain.Entities;

namespace School.Application.Contracts.Services
{
    public interface IAuthenticationService
    {
        Task<ApplicationUser> RegisterAsync(RegistrationRequest request);
        Task<Response<string>> ChangePasswordAsync(string userId, string oldPassword, string newPassword);
    }
}
