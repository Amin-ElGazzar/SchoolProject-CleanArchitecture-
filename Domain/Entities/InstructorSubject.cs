using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class InstructorSubject
    {

        [Key]
        public int InstructorId { get; set; }

        [Key]
        public int SubjectId { get; set; }

        [ForeignKey("InstructorId")]
        [InverseProperty("InstructorSubjects")]
        public Instructor Instructor { get; set; }


        [ForeignKey("SubjectId")]
        [InverseProperty("InstructorSubjects")]
        public Subject Subject { get; set; }

    }
}
