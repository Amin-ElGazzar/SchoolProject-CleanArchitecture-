using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Contracts.Repositories
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IStudentRepo StudentRepo { get; }

        Task<int> SaveChangesAsync();
    }
}
