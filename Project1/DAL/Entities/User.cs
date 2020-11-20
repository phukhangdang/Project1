using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Role { get; set; }
        public string AccountStatus { get; set; }
        public IEnumerable<FollowingRelationship> Followers { get; set; }
        public IEnumerable<Post> Statuses { get; set; }
        public IEnumerable<UserProfile> UserProfiles { get; set; }
        public IEnumerable<PostLike> PostLikes { get; set; }
        public IEnumerable<PostComment> PostComments { get; set; }

    }
}
