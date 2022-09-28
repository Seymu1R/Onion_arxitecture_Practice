using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UsersApp.Aplication.Interfaces;
using UsersApp.Domain.Entities;
using UsersApp.Persistence.Repositories;

namespace UsersappApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private IContract _contractrepository;

        public ContractController(IContract contractrepository)
        {
            _contractrepository = contractrepository;
        }
        [HttpGet]
        [Route("GetAllContract")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsersAsync()
        {
            List<ConTract> conTracts = (List<ConTract>)await _contractrepository.GetAllItemAsync();
            return Ok(conTracts);
        }
        [HttpGet]
        [Route("GetContarct/{id:int}")]
        public async Task<ActionResult<User>> GetContarct(int id)
        {
            ConTract contract = await _contractrepository.GetItembyIdAsync(id);
            return Ok(contract);
        }
        [HttpGet]
        [Route("GetContarctByUserId/{id:int}")]
        public async Task<ActionResult<User>> GetContarctByUserId([FromRoute]int id)
        {
            List<ConTract> conTracts = await _contractrepository.GetAllContractByid(id);
            return Ok(conTracts);
        }

        [HttpPost]
        [Route("AddContarct")]
        public async Task<ActionResult> CreateCont([FromBody] ConTract contarct)
        {
            bool Success = await _contractrepository.CreateItemAsync(contarct);
            if (!Success) return BadRequest();
            return Ok(Success);
        }
        [HttpDelete]
        [Route("DeleteContract/{id:int}")]
        public async Task<ActionResult> DeleteUser([FromRoute] int id)
        {
            bool Success = await _contractrepository.DeleteItembyIDAsync(id);
            if (!Success) return BadRequest();
            return Ok(Success);
        }
        [HttpPut]
        [Route("UpdateContarct/{id:int}")]
        public async Task<ActionResult<User>> UpdateUser([FromRoute] int id, ConTract conTract)
        {
            ConTract contractf = await _contractrepository.UpdateItemAsync(id);
            if (contractf is null) return NotFound();
            contractf.Title = conTract.Title;
            contractf.Description=conTract.Description; 
            await _contractrepository.SuccessingAsync();
            return Ok(contractf);
        }
    }
}
