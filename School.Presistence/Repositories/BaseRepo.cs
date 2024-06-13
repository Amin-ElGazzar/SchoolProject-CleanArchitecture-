using Microsoft.EntityFrameworkCore;
using School.Application.Contracts.Repositories;
using School.Presistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School.Presistence.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        #region fields
        private readonly ApplicationDbContext _context;
        #endregion

        #region constructor
        public BaseRepo(ApplicationDbContext context)
        {
           _context = context;
        }
        #endregion

        #region Handles function
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public virtual async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }
        public virtual T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return entity;
        }
        public void Delete(T entity)
        {
            _context.Remove(entity);
        }
        public virtual async Task<bool> IsExistAsync(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AnyAsync(expression);
        }

     
        #endregion

    }
}
