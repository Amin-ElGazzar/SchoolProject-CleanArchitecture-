using Microsoft.EntityFrameworkCore.Storage;

namespace School.Application.Contracts.Repositories
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IStudentRepo StudentRepo { get; }
        IDbContextTransaction BeginTransaction();
        Task<int> SaveChangesAsync();
    }
}
