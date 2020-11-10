using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class Post
    {
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public DateTime DatePublished { get; set; }
        public IEnumerable<PostLike> PostLikes { get; set; }
        public IEnumerable<PostComment> PostComments { get; set; }
        public IEnumerable<PostCategory> PostCategories { get; set; }

    }
}
