using Microsoft.EntityFrameworkCore.Storage;
using School.Application.Contracts.Repositories;
using School.Presistence.Data;

namespace School.Presistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;


        public IStudentRepo StudentRepo { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            StudentRepo = new StudentRepo(context);
        }
        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }
    }
}
