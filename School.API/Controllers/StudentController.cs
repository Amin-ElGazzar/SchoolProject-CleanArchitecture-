using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Application.Features.Students.Commends.Models.Request;
using School.Application.Features.Students.Queries.Models.Request;
using School.Domain.MetaData;

namespace School.API.Controllers
{
    [Route(Routing.root + "/[controller]")]
    [ApiController]
    public class StudentController : ControllerMain
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new StudentGetAllRequest());
            return GetResponse(result);
        }
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var result = await _mediator.Send(new StudentGetByIdRequest { Id = id });
            return GetResponse(result);

        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] StudentCreateRequest request)
        {
            var result = await _mediator.Send(request);
            return GetResponse(result);
        }
        [HttpPut("Edit")]
        public async Task<IActionResult> Edit(StudentEditRequest request)
        {
            var result = await _mediator.Send(request);
            return GetResponse(result);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new StudentDeleteRequest(id));
            return GetResponse(result);
        }


    }
}
