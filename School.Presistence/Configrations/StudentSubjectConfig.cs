using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Presistence.Configrations
{
    public class StudentSubjectConfig : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
            builder.HasKey(x => new { x.StudentId, x.SubjectId });
            builder.HasOne<Student>(ss => ss.Student)
                   .WithMany(s => s.StudentSubjects)
                   .HasForeignKey(ss => ss.StudentId);

            builder.HasOne<Subject>(ss => ss.Subject)
                   .WithMany(s => s.StudentsSubjects)
                   .HasForeignKey(ss => ss.SubjectId);
        }
    }
}
