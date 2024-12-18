﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.API.Base;
using School.Application.Features.User.Commends.Model.Request;
using School.Application.Features.User.Query.Models.Request;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerMain
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _mediator.Send(new UserGetAllRequest());
            return GetResponse(result);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> Get([FromRoute] string id)
        {
            var result = await _mediator.Send(new UserGetByIdRequest() { Id = id });
            return GetResponse(result);
        }
        [HttpPut("edit")]
        public async Task<IActionResult> EditUserAsync([FromForm] UserEditRequest request)
        {
            var result = await _mediator.Send(request);
            return GetResponse(result);
        }
        [HttpDelete("delete /{id}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string id)
        {
            var result = await _mediator.Send(new UserDeleteRequest() { UserId = id });
            return GetResponse(result);
        }
        ///ddddddddddddds
        ////
        //ddddddd
    }
}
