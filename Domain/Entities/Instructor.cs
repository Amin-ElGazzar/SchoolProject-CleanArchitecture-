using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class Instructor
    {
        public Instructor()
        {
            InstructorSubjects = new HashSet<InstructorSubject>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }

        public decimal Salary { get; set; }
        public int? SupervisorId { get; set; }
        [ForeignKey("SupervisorId")]
        [InverseProperty("Instructors")]
        public virtual Instructor Suprvisor { get; set; }

        [InverseProperty("Suprvisor")]
        public virtual ICollection<Instructor> Instructors { get; set; }


        [InverseProperty("Instructor")] // from table InstructorSubject
        public virtual ICollection<InstructorSubject> InstructorSubjects { get; set; }



        [InverseProperty("Manager")]
        public virtual Department DepartmentManage { get; set; }

    }
}
