using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class FollowerRelationship
    {
        public int FollowerRelationshipID { get; set;}
        public int UserID { get; set; }
        public int FollowerID { get; set; }
        public DateTime DateFollowed { get; set; }

    }
}
