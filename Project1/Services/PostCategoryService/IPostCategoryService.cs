using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Services.BaseService;

namespace Project1.Services.PostCategoryService
{
    public interface IPostCategoryService : IBaseService<PostCategory, PostCategoryDto>
    {
    }
}
