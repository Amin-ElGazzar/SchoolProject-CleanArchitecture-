using FluentValidation;
using Microsoft.AspNetCore.Identity;
using School.Application.Common.Extensions;
using School.Application.Features.Authentication.Commends.Models.Requests;
using School.Domain.Entities;

namespace School.Application.Features.Authentication.Commends.Validators
{
    public class RegistrationValidations : AbstractValidator<RegistrationRequest>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistrationValidations(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            applyValidator();
        }

        private void applyValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .NotNull()
                .MustAsync(async (key, CancellationToken) =>
                {
                    var user = await _userManager.FindByNameAsync(key);
                    return user == null;
                })
                .WithMessage("The username is already in use.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .MustAsync(async (key, CancellationToken) =>
                {
                    var user = await _userManager.FindByEmailAsync(key);
                    return user == null;
                })
                .WithMessage("The email is already in use.");

            RuleFor(x => x.ConfirmPassword)
               .Matches(x => x.Password)
               .WithMessage("Password and confirm password not same");

            RuleFor(x => x.Image)
               .NotEmpty()
               .Must((model, key, CancellationToken) => key.CheckImageExtension()).When(x => x.Image != null)
               .WithMessage("The picture must be in .png, .jpg, or .gif format.")
               .Must((model, key, CancellationToken) => key.CheckImageSize()).When(x => x.Image != null)
               .WithMessage("The size must be less than 2 megabytes.");
        }
    }
}
