using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.RoleService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public async Task<IEnumerable<RoleDto>> Get(int pageNum, int pageSize)
        {
            return await _roleService.FindAsync(pageNum, pageSize);
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<RoleDto> Get(int id)
        {
            return await _roleService.FindByIdAsync(id);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task<RoleDto> Post([FromBody] RoleDto Dto)
        {
            return await _roleService.CreateAsync(Dto);
        }

        // PUT api/<RoleController>/5
        [HttpPut]
        public async Task<RoleDto> Put([FromBody] RoleDto Dto)
        {
            return await _roleService.UpdateAsync(Dto);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _roleService.DeleteAsync(id);
        }
    }
}
