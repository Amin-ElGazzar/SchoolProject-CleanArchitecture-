using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Presistence.Configrations
{
    public class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(s => s.Suprvisor)
                   .WithMany(s => s.Instructors)
                   .HasForeignKey(s => s.SupervisorId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.Salary)
                   .HasColumnType("decimal(18, 2)");
        }
    }
}
