using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UsersApp.Aplication.Features.Queries.GetUsers;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;
using UsersApp.Persistence.Repositories;

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
        //[HttpGet]
        //[Route("GetUser/{id:int}")]
        //public async Task<ActionResult<User>> GetUser(int id)
        //{
        //    var user = await _userRepository.GetItembyIdAsync(id);
        //    return Ok(user);
        //}
        //[HttpPost]
        //[Route("AddUser")]
        //public async Task<ActionResult> CreateUser([FromBody] User user)
        //{
        //    bool Success = await _userRepository.CreateItemAsync(user);
        //    if (!Success) return BadRequest();
        //    return Ok(Success);
        //}
        //[HttpDelete]
        //[Route("DeleteUser/{id:int}")]
        //public async Task<ActionResult> DeleteUser([FromRoute] int id)
        //{
        //    bool Success = await _userRepository.DeleteItembyIDAsync(id);
        //    if (!Success) return BadRequest();
        //    return Ok(Success);
        //}
        //[HttpPut]
        //[Route("UpdataUser/{id:int}")]
        //public async Task<ActionResult<User>> UpdateUser([FromRoute] int id, User user)
        //{
        //    User userf = await _userRepository.UpdateItemAsync(id);
        //    if (userf is null) return NotFound();
        //    userf.UserName = user.UserName;
        //    userf.SurName = user.SurName;
        //    userf.FatherName = user.FatherName;
        //    userf.Name = user.Name;
        //    userf.Age = user.Age;
        //    await _userRepository.SuccessingAsync();
        //    return Ok(userf);
        //}
       
    }
}
