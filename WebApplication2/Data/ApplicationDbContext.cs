using System.Collections.Generic;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public ApplicationDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=Party;Trusted_Connection=True;")
        {
            People = this.Set<Person>();
        }
    }
}
