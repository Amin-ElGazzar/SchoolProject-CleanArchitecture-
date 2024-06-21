using AutoMapper;
using School.Application.Features.User.Commends.Model.Request;
using School.Domain.Entities;

namespace School.Application.Features.User.Commends.Mapping
{
    public class UserQueryProfile : Profile
    {
        public UserQueryProfile()
        {
            CreateMap<UserEditRequest, ApplicationUser>();
        }
    }
}
