using Microsoft.EntityFrameworkCore;
using School.Application.Contracts.Repositories;
using School.Domain.Entities;
using School.Presistence.Data;

namespace School.Presistence.Repositories
{
    public class StudentRepo : BaseRepo<Student>, IStudentRepo
    {
        private readonly ApplicationDbContext _context;

        public StudentRepo(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Student.Include(x => x.Department).ToListAsync();
        }

        public override void Delete(Student entity)
        {
            entity.IsDeleted = true;
            _context.Update(entity);
        }
    }
}
