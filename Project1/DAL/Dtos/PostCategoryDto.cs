using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class PostCategoryDto
    {
        public int PostCategoryDtoID { get; set; }
        public int PostID { get; set; }
        public int CategoryID { get; set; }
    }
}
