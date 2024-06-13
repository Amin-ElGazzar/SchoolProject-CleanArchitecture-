using AutoMapper;
using MediatR;
using Microsoft.Extensions.Localization;
using School.Application.Common.Models;
using School.Application.Contracts.Repositories;
using School.Application.Features.Students.Queries.Models.Request;
using School.Application.Features.Students.Queries.Models.Response;
using School.Application.SharedResources;

namespace School.Application.Features.Students.Queries.Handlers
{
    public class StudentQueriesHandlers : ResponseHandler, IRequestHandler<StudentGetAllRequest, Response<IEnumerable<StudentGetAllResponse>>>,
                                                          IRequestHandler<StudentGetByIdRequest, Response<StudentGetAllResponse>>
    {
        private readonly IUnitOfWork _repos;
        private readonly IMapper _mapper;

        public StudentQueriesHandlers(IUnitOfWork repos, IMapper mapper, IStringLocalizer<Resource> localizer) : base(localizer)
        {
            _repos = repos;
            _mapper = mapper;
        }
        public async Task<Response<IEnumerable<StudentGetAllResponse>>> Handle(StudentGetAllRequest request, CancellationToken cancellationToken)
        {
            var model = await _repos.StudentRepo.GetAllAsync();

            var result = _mapper.Map<IEnumerable<StudentGetAllResponse>>(model);
            return Success(result);
        }

        public async Task<Response<StudentGetAllResponse>> Handle(StudentGetByIdRequest request, CancellationToken cancellationToken)
        {
            var model = await _repos.StudentRepo.GetByIdAsync(request.Id);
            if (model == null) return NotFound<StudentGetAllResponse>();
            var result = _mapper.Map<StudentGetAllResponse>(model);
            return Success(result);
        }
    }
}
