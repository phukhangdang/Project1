using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Services.LoginService;
using Project1.Services.UserService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILoginService _loginService;
        public UserController(IUserService userService, ILoginService loginService)
        {
            _userService = userService;
            _loginService = loginService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get(int pageNum, int pageSize)
        {
            return await _userService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await _userService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        // [EnableCors("AllowAll")]
        public async Task<UserDto> Post([FromBody] UserDto Dto)
        {
            return await _userService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<UserDto> Put([FromBody] UserDto Dto)
        {
            return await _userService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }

        // GET LOGIN api/<UserController>/login
        [Route("login"), HttpPut]
        public async Task<UserDto> Login([FromBody] UserDto Dto)
        {
            return await _loginService.LoginAsync(Dto);
        }

    }
}
