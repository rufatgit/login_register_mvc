using Microsoft.EntityFrameworkCore;
using mvcapp.Models;



namespace mvcapp.Data
{
    public class mvcappDbContext : DbContext
    {
        public mvcappDbContext(DbContextOptions<mvcappDbContext> options) :base(options)
        {



        }

        public DbSet<User> Users{ get; set; }

        public DbSet<Profile> Profiles { get; set; }




    }
}
