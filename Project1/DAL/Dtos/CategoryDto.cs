using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class CategoryDto
    {
        public int CategoryDtoID { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<PostCategoryDto> PostCategories { get; set; }
    }
}
