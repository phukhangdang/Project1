using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.FollowService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowController : ControllerBase
    {
        private readonly IFollowService _followService;
        public FollowController(IFollowService followService)
        {
            _followService = followService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<FollowingRelationshipDto>> Get(int pageNum, int pageSize)
        {
            return await _followService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<FollowingRelationshipDto> Get(int id)
        {
            return await _followService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<FollowingRelationshipDto> Post([FromBody] FollowingRelationshipDto Dto)
        {
            return await _followService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<FollowingRelationshipDto> Put([FromBody] FollowingRelationshipDto Dto)
        {
            return await _followService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _followService.DeleteAsync(id);
        }
    }
}
