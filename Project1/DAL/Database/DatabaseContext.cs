using Microsoft.EntityFrameworkCore;
using Project1.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.DAL.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> UserRoles { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-QQ4A2OU; initial catalog=Project1; persist security info=True; user id=sa; password=12;");
        }
        */
    }
}
