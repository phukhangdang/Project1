using Project1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Dtos
{
    public class UserDto
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public IEnumerable<RoleDto> UserRole { get; set; }
        public IEnumerable<FollowDto> Follower { get; set; }
        public IEnumerable<StatusDto> Statuses { get; set; }
        public IEnumerable<UserAccountDto> AccountDtos { get; set; }
    }
}
