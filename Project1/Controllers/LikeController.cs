using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.LikeService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;
        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public async Task<IEnumerable<PostLikeDto>> Get(int pageNum, int pageSize)
        {
            return await _likeService.FindAsync(pageNum, pageSize);
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<PostLikeDto> Get(int id)
        {
            return await _likeService.FindByIdAsync(id);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task<PostLikeDto> Post([FromBody] PostLikeDto Dto)
        {
            return await _likeService.CreateAsync(Dto);
        }

        // PUT api/<RoleController>/5
        [HttpPut]
        public async Task<PostLikeDto> Put([FromBody] PostLikeDto Dto)
        {
            return await _likeService.UpdateAsync(Dto);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _likeService.DeleteAsync(id);
        }
    }
}
