namespace School.Application.Common.Models
{
    public class PaginatedResult<T>
    {
        public bool Succeded { get; set; }
        public int CurrentPage { get; set; }
        public int TotalCount { get; set; }
        public int TotalPage { get; set; }
        public int PageSize { get; set; }
        public IEnumerable<T> Data { get; set; }
        public bool HasPreviousPage => CurrentPage > 1;
        public bool HasNextPage => CurrentPage < TotalPage;



        internal PaginatedResult(bool succeded, IEnumerable<T> data, int currentPage = 1, int totalCount = 0, int pageSize = 10)
        {
            Succeded = succeded;
            CurrentPage = currentPage;
            TotalCount = totalCount;
            TotalPage = (int)Math.Ceiling(totalCount / (double)pageSize);
            PageSize = pageSize;
            Data = data;
        }

        public static PaginatedResult<T> Success(IEnumerable<T> data, int currentPage, int totalCount, int pageSize)
        {
            return new(true, data, currentPage, totalCount, pageSize);
        }
    }
}
