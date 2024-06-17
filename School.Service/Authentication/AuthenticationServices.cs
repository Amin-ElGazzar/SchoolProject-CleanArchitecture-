using Microsoft.AspNetCore.Identity;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Domain.Entities;
using IAuthenticationService = School.Application.Contracts.Services.IAuthenticationService;

namespace School.Service.Authentication
{
    public class AuthenticationServices : IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthenticationServices(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<ApplicationUser> RegisterAsync(RegistrationRequest request)
        {
            var user = new ApplicationUser
            {
                UserName = request.UserName,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Address = request.Address,

            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
            {
                string error = string.Empty;
                foreach (var item in result.Errors)
                {
                    error += $"{item.Description}";
                }
                throw new InvalidDataException(error);
            }
            return user;
        }
    }
}
