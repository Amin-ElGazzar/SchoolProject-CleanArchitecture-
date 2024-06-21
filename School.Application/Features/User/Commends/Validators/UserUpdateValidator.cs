using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using School.Application.Common.Extensions;
using School.Application.Features.User.Commends.Model.Request;
using School.Domain.Entities;

namespace School.Application.Features.User.Commends.Validators
{
    public class UserUpdateValidator : AbstractValidator<UserEditRequest>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserUpdateValidator(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            applyValidator();

        }

        private void applyValidator()
        {
            RuleFor(x => x)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.UserName)
                .NotEmpty()
                .NotNull()
                .MustAsync(async (model, key, CancellationToken) =>
                {

                    return !await _userManager.Users.AnyAsync(x => x.UserName == key && x.Id != model.Id);
                })
                .WithMessage("The username is already in use.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
            .MustAsync(async (model, key, CancellationToken) =>
                {
                    return !await _userManager.Users.AnyAsync(x => x.Email == key && x.Id != model.Id);
                })
                .WithMessage("The email is already in use.");


            RuleFor(x => x.Image)
               .NotEmpty()
               .Must((model, key, CancellationToken) => key.CheckImageExtension()).When(x => x.Image != null)
               .WithMessage("The picture must be in .png, .jpg, or .gif format.")
               .Must((model, key, CancellationToken) => key.CheckImageSize()).When(x => x.Image != null)
               .WithMessage("The size must be less than 2 megabytes.");
        }
    }
}
