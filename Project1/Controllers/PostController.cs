using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.PostService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostController(IPostService postService)
        {
            _postService = postService;
        }
        // GET: api/<StatusController>
        [HttpGet]
        public async Task<IEnumerable<PostDto>> Get(int pageNum, int pageSize)
        {
            return await _postService.FindAsync(pageNum, pageSize);
        }

        // GET api/<StatusController>/5
        [HttpGet("{id}")]
        public async Task<PostDto> Get(int id)
        {
            return await _postService.FindByIdAsync(id);
        }

        // POST api/<StatusController>
        [HttpPost]
        public async Task<PostDto> Post([FromBody] PostDto Dto)
        {
            return await _postService.CreateAsync(Dto);
        }

        // PUT api/<StatusController>/5
        [HttpPut]
        public async Task<PostDto> Put([FromBody] PostDto Dto)
        {
            return await _postService.UpdateAsync(Dto);
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _postService.DeleteAsync(id);
        }
    }
}
