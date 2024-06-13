using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using School.Domain.Entities;

namespace School.Presistence.Configrations
{
    public class InstructorSubjectConfig : IEntityTypeConfiguration<InstructorSubject>
    {
        public void Configure(EntityTypeBuilder<InstructorSubject> builder)
        {
            builder.HasKey(z => new { z.SubjectId, z.InstructorId });

            builder.HasOne<Instructor>(i => i.Instructor)
                   .WithMany(ins => ins.InstructorSubjects)
                   .HasForeignKey(i => i.InstructorId);
            builder.HasOne<Subject>(s => s.Subject)
                   .WithMany(sub => sub.InstructorSubjects)
                   .HasForeignKey(s => s.SubjectId);


        }
    }
}
