using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.PostCommentService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {
        private readonly IPostCommentService _postCommentService;
        public PostCommentController(IPostCommentService postCommentService)
        {
            _postCommentService = postCommentService;
        }
        // GET: api/<UserAccountController>
        [HttpGet]
        public async Task<IEnumerable<PostCommentDto>> Get(int pageNum, int pageSize)
        {
            return await _postCommentService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserAccountController>/5
        [HttpGet("{id}")]
        public async Task<PostCommentDto> Get(int id)
        {
            return await _postCommentService.FindByIdAsync(id);
        }

        // POST api/<UserAccountController>
        [HttpPost]
        public async Task<PostCommentDto> Post([FromBody] PostCommentDto Dto)
        {
            return await _postCommentService.CreateAsync(Dto);
        }

        // PUT api/<UserAccountController>/5
        [HttpPut]
        public async Task<PostCommentDto> Put([FromBody] PostCommentDto Dto)
        {
            return await _postCommentService.UpdateAsync(Dto);
        }

        // DELETE api/<UserAccountController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _postCommentService.DeleteAsync(id);
        }
    }
}
