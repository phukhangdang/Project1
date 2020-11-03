using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class PostCategory
    {
        public int PostCategoryID { get; set; }
        public int PostID { get; set; }
        public int CategoryID { get; set; }
    }
}
