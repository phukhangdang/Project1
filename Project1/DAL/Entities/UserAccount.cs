using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class UserAccount
    {
        public int UserAccountID { get; set; }
        public int UserID { get; set; }
        public string Account { get; set; }
        public string Passwork { get; set; }

    }
}
