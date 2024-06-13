using MediatR;
using School.Application.Common.Models;

namespace School.Application.Features.Students.Commends.Models.Request
{
    public class StudentEditRequest : IRequest<Response<string>>
    {
        public int StudID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? DepartmentId { get; set; }
    }
}
