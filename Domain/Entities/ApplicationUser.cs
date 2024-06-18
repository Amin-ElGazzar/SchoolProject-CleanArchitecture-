using Microsoft.AspNetCore.Identity;

namespace School.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public string? ImageUrl { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public string? CreatedUserId { get; set; }
        public string? LastUpdatedUserId { get; set; }
        public string? DeletedUserId { get; set; }
    }
}
