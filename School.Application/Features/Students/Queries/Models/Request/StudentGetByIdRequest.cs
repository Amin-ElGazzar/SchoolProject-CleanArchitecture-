using MediatR;
using School.Application.Common.Models;
using School.Application.Features.Students.Queries.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Features.Students.Queries.Models.Request
{
    public class StudentGetByIdRequest :IRequest<Response<StudentGetAllResponse>>
    {
        public int Id { get; set; }
    }
}
