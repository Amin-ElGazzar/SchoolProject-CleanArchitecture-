using MediatR;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Contracts.Services;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Application.Features.Authentication.Commends.Models.Response;
using School.Application.SharedResources;
using System.Security.Claims;

namespace School.Application.Features.Authentication.Commends.Handlers
{
    public class AuthenticationHandler : ResponseHandler,
                                                        IRequestHandler<RegistrationRequest, Response<string>>,
                                                        IRequestHandler<SignInRequest, Response<TokenModleResponse>>,
                                                        IRequestHandler<ChangePasswordRequest, Response<string>>

    {
        private readonly IAuthenticationService _authenticationService;
        #region fields
        #endregion

        #region Constructor
        public AuthenticationHandler(IStringLocalizer<Resource> localizer, IAuthenticationService authenticationService) : base(localizer)
        {
            _authenticationService = authenticationService;
        }
        #endregion
        public async Task<Response<string>> Handle(RegistrationRequest request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.RegisterAsync(request);

            return Created<string>();
        }

        public Task<Response<string>> Handle(ChangePasswordRequest request, CancellationToken cancellationToken)
        {
            var userId = request.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var result = _authenticationService.ChangePasswordAsync(userId, request.Model.OldPassword, request.Model.NewPassword);
            return result;
        }

        public async Task<Response<TokenModleResponse>> Handle(SignInRequest request, CancellationToken cancellationToken)
        {
            var result = await _authenticationService.SignInAsync(request);
            return Success(result);
        }
    }
}
