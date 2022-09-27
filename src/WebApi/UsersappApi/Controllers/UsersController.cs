using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
        [Route("AddUser")]
        public async Task<bool> CreateUser( [FromBody] User user) 
        {
           return await _userRepository.CreateItemAsync(user);
        }
    }
}
