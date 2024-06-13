using Microsoft.EntityFrameworkCore;

namespace School.Application.Common.Models
{
    public static class IQueryableExtension
    {
        public static async Task<PaginatedResult<T>> ToPaginationListAsync<T>(this IQueryable<T> source, int pageNumber = 1, int pageSize = 10) where T : class
        {
            if (source == null) throw new Exception("Empty");

            pageNumber = pageNumber <= 0 ? 1 : pageNumber;
            pageSize = pageSize <= 0 ? 10 : pageSize;

            var count = source.Count();
            if (count == 0)
            {
                return PaginatedResult<T>.Success(new List<T>(), pageNumber, count, pageSize);
            }

            var date = await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return PaginatedResult<T>.Success(date, pageNumber, count, pageSize);

        }
    }
}
