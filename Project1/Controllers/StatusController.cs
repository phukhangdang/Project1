using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.StatusService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IStatusService _statusService;
        public StatusController(IStatusService statusService)
        {
            _statusService = statusService;
        }
        // GET: api/<StatusController>
        [HttpGet]
        public async Task<IEnumerable<StatusDto>> Get(int pageNum, int pageSize)
        {
            return await _statusService.FindAsync(pageNum, pageSize);
        }

        // GET api/<StatusController>/5
        [HttpGet("{id}")]
        public async Task<StatusDto> Get(int id)
        {
            return await _statusService.FindByIdAsync(id);
        }

        // POST api/<StatusController>
        [HttpPost]
        public async Task<StatusDto> Post([FromBody] StatusDto Dto)
        {
            return await _statusService.CreateAsync(Dto);
        }

        // PUT api/<StatusController>/5
        [HttpPut]
        public async Task<StatusDto> Put([FromBody] StatusDto Dto)
        {
            return await _statusService.UpdateAsync(Dto);
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _statusService.DeleteAsync(id);
        }
    }
}
