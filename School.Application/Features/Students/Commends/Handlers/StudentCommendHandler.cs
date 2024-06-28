using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Contracts.Repositories;
using School.Application.Features.Students.Commends.Models.Request;
using School.Application.SharedResources;
using School.Domain.Entities;

namespace School.Application.Features.Students.Commends.Handlers
{
    public class StudentCommendHandler : ResponseHandler,
                                                        IRequestHandler<StudentCreateRequest, Response<string>>,
                                                        IRequestHandler<StudentEditRequest, Response<string>>,
                                                        IRequestHandler<StudentDeleteRequest, Response<string>>
    {
        private readonly IUnitOfWork _repos;
        private readonly IMapper _mapper;

        public StudentCommendHandler(IUnitOfWork repos, IMapper mapper, IStringLocalizer<Resource> localizer) : base(localizer)
        {
            _repos = repos;
            _mapper = mapper;
        }
        public async Task<Response<string>> Handle(StudentCreateRequest request, CancellationToken cancellationToken)
        {
            var model = _mapper.Map<Student>(request);
            await _repos.StudentRepo.AddAsync(model);
            await _repos.SaveChangesAsync();
            return Created<string>();
        }

        public async Task<Response<string>> Handle(StudentEditRequest request, CancellationToken cancellationToken)
        {
            var student = await _repos.StudentRepo.GetByIdAsync(request.StudID);
            if (student == null) return NotFound<string>();
            _mapper.Map(request, student);
            _repos.StudentRepo.Update(student);
            await _repos.SaveChangesAsync();
            return EditSuccess<string>();

        }

        public async Task<Response<string>> Handle(StudentDeleteRequest request, CancellationToken cancellationToken)
        {
            var student = await _repos.StudentRepo.GetByIdAsync(request.Id);
            //if (student == null) return NotFound<string>();
            _repos.StudentRepo.Delete(student);
            await _repos.SaveChangesAsync();
            return Deleted<string>();
        }
    }
}
