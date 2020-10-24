using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Entities
{
    public class Status
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Like { get; set; }
        public int Comment { get; set; }
    }
}
