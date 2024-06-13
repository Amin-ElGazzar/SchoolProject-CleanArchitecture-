using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using System.Reflection;

namespace School.Presistence.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentSubject> DepartmetSubject { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentSubject> StudentSubject { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
