using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.FollowedRelationshipService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FollowedRelationshipController : ControllerBase
    {
        private readonly IFollowedRelationshipService _followedRelationshipService;
        public FollowedRelationshipController(IFollowedRelationshipService followedRelationshipService)
        {
            _followedRelationshipService = followedRelationshipService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<FollowedRelationshipDto>> Get(int pageNum, int pageSize)
        {
            return await _followedRelationshipService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<FollowedRelationshipDto> Get(int id)
        {
            return await _followedRelationshipService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<FollowedRelationshipDto> Post([FromBody] FollowedRelationshipDto Dto)
        {
            return await _followedRelationshipService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<FollowedRelationshipDto> Put([FromBody] FollowedRelationshipDto Dto)
        {
            return await _followedRelationshipService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _followedRelationshipService.DeleteAsync(id);
        }
    }
}
