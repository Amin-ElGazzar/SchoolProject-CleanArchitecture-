using FluentValidation;
using Microsoft.Extensions.Localization;
using School.Application.Contracts.Repositories;
using School.Application.Features.Students.Commends.Models.Request;
using School.Application.SharedResources;

namespace School.Application.Features.Students.Commends.Validators
{
    public class StudentCreateValidator : AbstractValidator<StudentCreateRequest>
    {
        private readonly IUnitOfWork _repos;
        private readonly IStringLocalizer<Resource> _localizer;

        public StudentCreateValidator(IUnitOfWork repos, IStringLocalizer<Resource> localizer)
        {
            _repos = repos;
            _localizer = localizer;
            applyValidator();
        }

        private void applyValidator()
        {
            RuleFor(s => s.Name)
                          .NotEmpty()
                          .NotNull()
                          .MustAsync(async (key, CancellationToken) => !await _repos.StudentRepo.IsExistAsync(s => s.Name == key))
                          .WithMessage(_localizer[ResourceKey.Name]);
        }
    }
}
