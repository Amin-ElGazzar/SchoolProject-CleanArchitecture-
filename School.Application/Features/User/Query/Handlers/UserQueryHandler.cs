using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Features.User.Query.Models.Request;
using School.Application.Features.User.Query.Models.responses;
using School.Application.SharedResources;
using School.Domain.Entities;

namespace School.Application.Features.User.Query.Handlers
{
    public class UserQueryHandler : ResponseHandler,
                                                  IRequestHandler<UserGetAllRequest, Response<IEnumerable<UserGetAllResponse>>>,
                                                  IRequestHandler<UserGetByIdRequest, Response<UserGetAllResponse>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserQueryHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IStringLocalizer<Resource> localizer) : base(localizer)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<UserGetAllResponse>>> Handle(UserGetAllRequest request, CancellationToken cancellationToken)
        {
            var models = await _userManager.Users.ToListAsync();
            var result = _mapper.Map<IEnumerable<UserGetAllResponse>>(models);
            return Success(result);
        }

        public async Task<Response<UserGetAllResponse>> Handle(UserGetByIdRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == request.Id);
            var result = _mapper.Map<UserGetAllResponse>(user);
            return Success(result);
        }
    }
}
