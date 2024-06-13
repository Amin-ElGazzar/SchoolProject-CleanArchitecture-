using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Presistence.Configrations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(d => d.Department)
                 .WithMany(s => s.Students)
                 .HasForeignKey(s => s.DepartmentId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
