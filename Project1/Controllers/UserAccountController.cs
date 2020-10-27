using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.UserAccountService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountService _userAccountService;
        public UserAccountController(IUserAccountService userAccountService)
        {
            _userAccountService = userAccountService;
        }
        // GET: api/<UserAccountController>
        [HttpGet]
        public async Task<IEnumerable<UserAccountDto>> Get()
        {
            return await _userAccountService.FindAsync();
        }

        // GET api/<UserAccountController>/5
        [HttpGet("{id}")]
        public async Task<UserAccountDto> Get(int id)
        {
            return await _userAccountService.FindByIdAsync(id);
        }

        // POST api/<UserAccountController>
        [HttpPost]
        public async Task<UserAccountDto> Post([FromBody] UserAccountDto Dto)
        {
            return await _userAccountService.CreateAsync(Dto);
        }

        // PUT api/<UserAccountController>/5
        [HttpPut]
        public async Task<UserAccountDto> Put([FromBody] UserAccountDto Dto)
        {
            return await _userAccountService.UpdateAsync(Dto);
        }

        // DELETE api/<UserAccountController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userAccountService.DeleteAsync(id);
        }
    }
}
