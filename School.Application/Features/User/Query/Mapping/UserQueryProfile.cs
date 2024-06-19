using AutoMapper;
using School.Application.Features.User.Query.Models.responses;
using School.Domain.Entities;

namespace School.Application.Features.User.Query.Mapping
{
    public class UserQueryProfile : Profile
    {
        public UserQueryProfile()
        {
            CreateMap<ApplicationUser, UserGetAllResponse>();
        }
    }
}
