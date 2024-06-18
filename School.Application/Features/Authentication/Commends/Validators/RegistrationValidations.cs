using FluentValidation;
using Microsoft.AspNetCore.Identity;
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
        }
    }
}
