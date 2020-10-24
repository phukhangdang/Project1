using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public IEnumerable<Role> UserRole { get; set; }
        public IEnumerable<Follow> Follower { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
    }
}
