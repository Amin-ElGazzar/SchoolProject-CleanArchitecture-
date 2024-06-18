namespace School.Application.Features.User.Query.Models.responses
{
    public class UserGetAllResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string? ImageUrl { get; set; }
    }
}
