using FluentValidation;
using School.Application.Contracts.Repositories;
using School.Application.Features.Students.Commends.Models.Request;

namespace School.Application.Features.Students.Commends.Validators
{
    public class StudentEditValidator : AbstractValidator<StudentEditRequest>
    {
        private readonly IUnitOfWork _repos;

        public StudentEditValidator(IUnitOfWork repos)
        {

            _repos = repos;
            applyValidator();
        }

        private void applyValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MustAsync(async (request, key, CancellationToken) => !await _repos.StudentRepo.IsExistAsync(x => x.Name == key && x.StudID != request.StudID))
                .WithMessage("{PropertyName} already exist");
        }
    }
}
