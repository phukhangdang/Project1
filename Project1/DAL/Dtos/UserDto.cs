using Project1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class UserDto
    {
        public int UserDtoID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Role { get; set; }
        public string AccountStatus { get; set; }
        public IEnumerable<FollowerRelationshipDto> Followers { get; set; }
        public IEnumerable<FollowedRelationship> Followeds { get; set; }
        public IEnumerable<PostDto> Statuses { get; set; }
        public IEnumerable<UserProfileDto> UserProfiles { get; set; }
        public IEnumerable<PostLikeDto> PostLikes { get; set; }
        public IEnumerable<PostCommentDto> PostComments { get; set; }

    }
}
