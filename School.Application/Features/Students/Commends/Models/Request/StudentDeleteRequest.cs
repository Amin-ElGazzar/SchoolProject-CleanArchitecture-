using MediatR;
using School.Application.Common.Models;

namespace School.Application.Features.Students.Commends.Models.Request
{
    public class StudentDeleteRequest : IRequest<Response<string>>
    {
        public int Id { get; set; }

        public StudentDeleteRequest(int id)
        {
            Id = id;
        }
    }
}
