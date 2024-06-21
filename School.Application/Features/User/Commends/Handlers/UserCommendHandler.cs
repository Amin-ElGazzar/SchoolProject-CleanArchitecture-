using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Features.User.Commends.Model.Request;
using School.Application.SharedResources;
using School.Domain.Entities;

namespace School.Application.Features.User.Commends.Handlers
{
    public class UserCommendHandler : ResponseHandler,
                                                    IRequestHandler<UserEditRequest, Response<string>>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserCommendHandler(UserManager<ApplicationUser> userManager, IMapper mapper, IStringLocalizer<Resource> localizer) : base(localizer)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(UserEditRequest request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.Id);
            if (user == null) NotFound<string>();
            _mapper.Map(request, user);
            await _userManager.UpdateAsync(user);
            return EditSuccess<string>();
        }
    }
}
