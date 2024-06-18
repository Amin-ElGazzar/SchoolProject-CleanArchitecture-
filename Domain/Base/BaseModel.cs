using School.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Base
{
    public abstract class BaseModel
    {
        public bool IsDeleted { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public string? CreatedUserId { get; set; }
        public string? LastUpdatedUserId { get; set; }
        public string? DeletedUserId { get; set; }

        [ForeignKey(nameof(CreatedUserId))]
        public virtual ApplicationUser? CreatedUser { get; set; }
        [ForeignKey(nameof(LastUpdatedUserId))]
        public virtual ApplicationUser? LastUpdatedUser { get; set; }
        [ForeignKey(nameof(DeletedUserId))]
        public virtual ApplicationUser? DeletedUser { get; set; }
    }
}
