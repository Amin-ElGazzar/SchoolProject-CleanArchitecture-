using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Contracts.Services;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Application.Features.Authentication.Commends.Models.Response;
using School.Application.SharedResources;
using School.Domain.Entities;


namespace School.Service.Authentication
{
    public class AuthenticationServices : ResponseHandler, IAuthenticationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ITokenService _tokenService;

        public AuthenticationServices(UserManager<ApplicationUser> userManager,
            IStringLocalizer<Resource> localizer,
            ITokenService tokenService) : base(localizer)
        {
            _userManager = userManager;
            _tokenService = tokenService;
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



        public async Task<TokenModleResponse> SignInAsync(SignInRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.UserName);
            user = user ??= await _userManager.FindByNameAsync(request.UserName);
            if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
            {
                return new TokenModleResponse() { IsAuthenticated = false, Message = "Username or Password is incorrect!" };
            }
            var token = await _tokenService.GetToken(user);
            token.IsAuthenticated = true;
            return token;
        }

        public async Task<Response<string>> ChangePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) return BadRequest<string>("user not registered");

            var passwordChangeResult = await _userManager.ChangePasswordAsync(user, oldPassword, newPassword);
            if (!passwordChangeResult.Succeeded)
            {
                return BadRequest<string>("Failed to change password");
            }
            return Success<string>("success");
        }
    }
}
