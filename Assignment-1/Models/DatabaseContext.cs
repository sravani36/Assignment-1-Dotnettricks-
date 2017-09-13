using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_1.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
                : base("name=DbConnection")
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
