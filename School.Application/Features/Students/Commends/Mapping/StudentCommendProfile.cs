using AutoMapper;
using School.Application.Features.Students.Commends.Models.Request;
using School.Domain.Entities;

namespace School.Application.Features.Students.Commends.Mapping
{
    public class StudentCommendProfile : Profile
    {
        public StudentCommendProfile()
        {
            CreateMap<StudentCreateRequest, Student>()
                .ForMember(dist => dist.DepartmentId, option => option.MapFrom(src => src.DepartmentId));

            CreateMap<StudentEditRequest, Student>()
                .ForMember(dist => dist.DepartmentId, option => option.MapFrom(src => src.DepartmentId));

        }
    }
}
