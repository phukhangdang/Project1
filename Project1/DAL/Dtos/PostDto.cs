using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class PostDto
    {
        public int PostDtoID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public IEnumerable<PostLikeDto> PostLikes { get; set; }
        public IEnumerable<PostCommentDto> PostComments { get; set; }
        public IEnumerable<PostCategoryDto> PostCategories { get; set; }

    }
}
