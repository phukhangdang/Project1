using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.CommentService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        // GET: api/<UserAccountController>
        [HttpGet]
        public async Task<IEnumerable<CommentDto>> Get(int pageNum, int pageSize)
        {
            return await _commentService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserAccountController>/5
        [HttpGet("{id}")]
        public async Task<CommentDto> Get(int id)
        {
            return await _commentService.FindByIdAsync(id);
        }

        // POST api/<UserAccountController>
        [HttpPost]
        public async Task<CommentDto> Post([FromBody] CommentDto Dto)
        {
            return await _commentService.CreateAsync(Dto);
        }

        // PUT api/<UserAccountController>/5
        [HttpPut]
        public async Task<CommentDto> Put([FromBody] CommentDto Dto)
        {
            return await _commentService.UpdateAsync(Dto);
        }

        // DELETE api/<UserAccountController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _commentService.DeleteAsync(id);
        }
    }
}
