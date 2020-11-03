using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class PostComment
    {
        public int PostCommentID { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
        public DateTime DateCommented { get; set; }

    }
}
