using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Contracts.Repositories
{
    public interface IBaseRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<bool> IsExistAsync(Expression<Func<T, bool>> expression);
      
    }
}
