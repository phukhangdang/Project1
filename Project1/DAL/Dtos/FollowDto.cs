using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class FollowDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int FollowerID { get; set; }
        public DateTime Time { get; set; }

    }
}
