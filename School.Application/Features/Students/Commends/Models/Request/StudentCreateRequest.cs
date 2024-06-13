using MediatR;
using School.Application.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Features.Students.Commends.Models.Request
{
    public class StudentCreateRequest:IRequest<Response<string>>
    {
       
        public string Name { get; set; }      
        public string Address { get; set; }     
        public string Phone { get; set; }
        public int? DepartmentId { get; set; }
    }
}
