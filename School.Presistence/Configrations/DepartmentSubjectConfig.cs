using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Presistence.Configrations
{
    public class DepartmentSubjectConfig : IEntityTypeConfiguration<DepartmentSubject>
    {
        public void Configure(EntityTypeBuilder<DepartmentSubject> builder)
        {
            builder.HasKey(x => new { x.DepartmentId, x.SubjectId });
            builder.HasOne<Department>(ds => ds.Department)
                   .WithMany(d => d.DepartmentsSubjects)
                   .HasForeignKey(ds => ds.DepartmentId);

            builder.HasOne<Subject>(ds => ds.Subject)
                .WithMany(s => s.DepartmentsSubjects)
                .HasForeignKey(ds => ds.SubjectId);

        }
    }
}
