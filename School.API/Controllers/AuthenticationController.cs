using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Application.Features.Authentication.Commends.ViewModel;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerMain
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromForm] RegistrationRequest request)
        {
            var result = await _mediator.Send(request);
            return GetResponse(result);
        }

        [HttpPost("signIn")]
        public async Task<IActionResult> SignInAsync([FromBody] SignInRequest request)
        {
            var result = await _mediator.Send(request);
            return GetResponse(result);
        }

        [HttpPut("changePassword")]
        public async Task<IActionResult> ChangePasswordAsync(ChangePasswordViewModel request)
        {
            ChangePasswordRequest model = new ChangePasswordRequest(request, User);
            var resutl = await _mediator.Send(model);
            return GetResponse(resutl);
        }
    }
}
