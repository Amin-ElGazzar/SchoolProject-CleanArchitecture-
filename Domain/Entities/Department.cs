using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Domain.Entities
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
            DepartmentsSubjects = new HashSet<DepartmentSubject>();

        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        [StringLength(200)]
        public string DName { get; set; }


        [InverseProperty("Department")]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<DepartmentSubject> DepartmentsSubjects { get; set; }



        public int ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        [InverseProperty("DepartmentManage")]
        public virtual Instructor Manager { get; set; }
    }

}
