﻿using Project1.DAL.Dtos;
using Project1.DAL.Entities;
using Project1.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.CategoryService
{
    public interface ICategoryService : IBaseService<Category, CategoryDto>
    {
    }
}
