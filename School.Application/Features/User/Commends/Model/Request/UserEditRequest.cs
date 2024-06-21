using MediatR;
using Microsoft.AspNetCore.Http;
using School.Application.Common.Models;

namespace School.Application.Features.User.Commends.Model.Request
{
    public class UserEditRequest : IRequest<Response<string>>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }
    }
}
