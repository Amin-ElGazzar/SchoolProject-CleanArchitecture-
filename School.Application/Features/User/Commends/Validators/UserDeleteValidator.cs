using FluentValidation;
using School.Application.Features.User.Commends.Model.Request;

namespace School.Application.Features.User.Commends.Validators
{
    public class UserDeleteValidator : AbstractValidator<UserDeleteRequest>
    {
        public UserDeleteValidator() { }

        private void applyValidator()
        {
            RuleFor(x => x.UserId)
                .NotNull()
                .NotEmpty();
        }
    }
}
