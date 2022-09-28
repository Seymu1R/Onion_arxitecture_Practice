using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;
using UsersApp.Persistence.Repositories;

namespace UsersappApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUser _userRepository;

        public UsersController(IUser userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        [Route("GetAllUsers")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllItemAsync();
            return Ok(users);
        }
        [HttpGet]
        [Route("GetUser/{id:int}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _userRepository.GetItembyIdAsync(id);
            return Ok(user);
        }
        [HttpPost]
        [Route("AddUser")]
        public async Task<ActionResult> CreateUser([FromBody] User user)
        {
            bool Success = await _userRepository.CreateItemAsync(user);
            if (!Success) return BadRequest();
            return Ok(Success);
        }
        [HttpDelete]
        [Route("DeleteUser/{id:int}")]
        public async Task<ActionResult> DeleteUser([FromRoute] int id)
        {
            bool Success = await _userRepository.DeleteItembyIDAsync(id);
            if (!Success) return BadRequest();
            return Ok(Success);
        }
        [HttpPut]
        [Route("UpdataUser/{id:int}")]
        public async Task<ActionResult<User>> UpdateUser([FromRoute] int id, User user)
        {
            User userf = await _userRepository.UpdateItemAsync(id);
            if (userf is null) return NotFound();
            userf.UserName = user.UserName;
            userf.SurName = user.SurName;
            userf.FatherName = user.FatherName;
            userf.Name = user.Name;
            userf.Age = user.Age;
            await _userRepository.SuccessingAsync();
            return Ok(userf);
        }
       
    }
}
