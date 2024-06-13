using MediatR;
using School.Application.Common.Models;
using School.Application.Features.Students.Queries.Models.Response;

namespace School.Application.Features.Students.Queries.Models.Request
{
    public class StudentGetAllWithPaginationRequest : IRequest<Response<PaginatedResult<StudentGetAllResponse>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
