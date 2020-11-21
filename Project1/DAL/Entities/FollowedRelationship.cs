using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class FollowedRelationship
    {
        public int FollowedRelationshipID { get; set; }
        public int UserID { get; set; }
        public int FollowedID { get; set; }
        public DateTime DateFollowed { get; set; }

    }
}
