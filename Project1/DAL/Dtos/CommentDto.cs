﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class CommentDto
    {
        public int ID { get; set; }
        public int StatusID { get; set; }
        public int UserID { get; set; }
        public DateTime Time { get; set; }
    }
}