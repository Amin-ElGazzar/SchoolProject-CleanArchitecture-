using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Presistence.Configrations
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasOne(i => i.Manager)
                   .WithOne(s => s.DepartmentManage)
                   .HasForeignKey<Department>(d => d.ManagerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(d => d.DID);

            builder.Property(d => d.DName)
                   .HasMaxLength(200);




        }


    }
}
