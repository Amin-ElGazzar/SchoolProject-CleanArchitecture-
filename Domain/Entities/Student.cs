using School.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public class Student : BaseModel
    {
        public Student()
        {
            StudentSubjects = new HashSet<StudentSubject>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(500)]
        public string Phone { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        [InverseProperty("Students")]
        public virtual Department Department { get; set; }

        [InverseProperty("Student")]
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
