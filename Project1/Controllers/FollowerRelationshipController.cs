using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.FollowerRelationshipService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowerRelationshipController : ControllerBase
    {
        private readonly IFollowerRelationshipService _followerRelationshipService;
        public FollowerRelationshipController(IFollowerRelationshipService followerRelationshipService)
        {
            _followerRelationshipService = followerRelationshipService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<FollowerRelationshipDto>> Get(int pageNum, int pageSize)
        {
            return await _followerRelationshipService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<FollowerRelationshipDto> Get(int id)
        {
            return await _followerRelationshipService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<FollowerRelationshipDto> Post([FromBody] FollowerRelationshipDto Dto)
        {
            return await _followerRelationshipService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<FollowerRelationshipDto> Put([FromBody] FollowerRelationshipDto Dto)
        {
            return await _followerRelationshipService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _followerRelationshipService.DeleteAsync(id);
        }
    }
}
