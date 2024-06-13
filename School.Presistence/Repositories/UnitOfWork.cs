using School.Application.Contracts.Repositories;
using School.Domain.Entities;
using School.Presistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Presistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

      
        public IStudentRepo StudentRepo {  get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            StudentRepo = new StudentRepo(context);
        }
        public ValueTask DisposeAsync()
        {
          return  _context.DisposeAsync();
        }

        public Task<int> SaveChangesAsync()
        {
           return _context.SaveChangesAsync();
        }
    }
}
