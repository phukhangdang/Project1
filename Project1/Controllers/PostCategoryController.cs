using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.DAL.Dtos;
using Project1.Services.PostCategoryService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCategoryController : ControllerBase
    {
        private readonly IPostCategoryService _postCategoryService;
        public PostCategoryController(IPostCategoryService postCategoryService)
        {
            _postCategoryService = postCategoryService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IEnumerable<PostCategoryDto>> Get(int pageNum, int pageSize)
        {
            return await _postCategoryService.FindAsync(pageNum, pageSize);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<PostCategoryDto> Get(int id)
        {
            return await _postCategoryService.FindByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<PostCategoryDto> Post([FromBody] PostCategoryDto Dto)
        {
            return await _postCategoryService.CreateAsync(Dto);
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public async Task<PostCategoryDto> Put([FromBody] PostCategoryDto Dto)
        {
            return await _postCategoryService.UpdateAsync(Dto);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _postCategoryService.DeleteAsync(id);
        }
    }
}
