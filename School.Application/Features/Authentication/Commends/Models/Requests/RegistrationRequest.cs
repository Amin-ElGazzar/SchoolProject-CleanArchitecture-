using MediatR;
using School.Application.Common.Models;
using System.ComponentModel.DataAnnotations;

namespace School.Application.Features.Authentication.Commends.Models.Requests
{
    public class RegistrationRequest : IRequest<Response<string>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
