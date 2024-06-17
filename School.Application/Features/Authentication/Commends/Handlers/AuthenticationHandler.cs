using MediatR;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Contracts.Services;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Application.SharedResources;

namespace School.Application.Features.Authentication.Commends.Handlers
{
    public class AuthenticationHandler : ResponseHandler
                                                       , IRequestHandler<RegistrationRequest, Response<string>>
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
    }
}
