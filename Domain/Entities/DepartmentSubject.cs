using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class DepartmentSubject
    {
        [Key]
        public int DepartmentId { get; set; }
        [Key]
        public int SubjectId { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("DepartmentsSubjects")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubjectId")]
        [InverseProperty("DepartmentsSubjects")]
        public virtual Subject Subject { get; set; }

    }
}
