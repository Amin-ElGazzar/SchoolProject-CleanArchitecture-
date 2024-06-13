using AutoMapper;
using School.Application.Features.Students.Queries.Models.Response;
using School.Domain.Entities;

namespace School.Application.Features.Students.Queries.Mapping
{
    public class StudentQueriesProfile : Profile
    {
        public StudentQueriesProfile()
        {
            GetAllMapping();
        }

        private void GetAllMapping()
        {
            CreateMap<Student, StudentGetAllResponse>()
                .ForMember(dist=>dist.DepartmentName,opt=>opt.MapFrom(src=>src.Department.DName));

        }
    }
}
