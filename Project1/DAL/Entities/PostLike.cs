﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class PostLike
    {
        public int PostLikeID { get; set; }
        public int StatusID { get; set; }
        public int UserID { get; set; }
        public DateTime DateLiked { get; set; }

    }
}
