using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UsersApp.Aplication.Features.Commads;
using UsersApp.Aplication.Features.Commads.DeleteUserComand;
using UsersApp.Aplication.Features.Commads.UpdateUserComand;
using UsersApp.Aplication.Features.Queries.GetUsers;
using UsersApp.Aplication.Features.Queries.GetUsers.GetProductById;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;
using UsersApp.Persistence.Repositories;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UsersappApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersAsync()
        {
            var query = new GetAllUsersQuery();
            
            return Ok(await _mediator.Send(query));
        }
        [HttpGet]
        [Route("GetUser/{id:int}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var query = new GetUserByIdQuery() { Id = id };
            return Ok(await _mediator.Send(query)); 
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult> CreateUser(CreateUserComand comand)
        {
            return Ok(await _mediator.Send(comand));
        }
        [HttpDelete]
        [Route("DeleteUser/{id:int}")]
        public async Task<ActionResult> DeleteUser([FromRoute] int id)
        {
            var comand = new DeleteUserComand { Id = id };            
            return Ok(await _mediator.Send(comand));
        }
        [HttpPut]
        [Route("UpdataUser/{id:int}")]
        public async Task<ActionResult<bool>> UpdateUser([FromRoute] int id, UpdateUserComand comand)
        {
            comand.Id = id;
            
            return Ok(await _mediator.Send(comand));

        }

    }
}
