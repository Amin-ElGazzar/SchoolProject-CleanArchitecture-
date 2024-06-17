using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Application.Features.Authentication.Commends.Models.Requests;

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
        public async Task<IActionResult> RegisterAsync(RegistrationRequest request)
        {
            var result = await _mediator.Send(request);
            return GetResponse(result);
        }
    }
}
