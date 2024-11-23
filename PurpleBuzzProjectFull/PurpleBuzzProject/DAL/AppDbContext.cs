using Microsoft.EntityFrameworkCore;
using PurpleBuzzProject.Models;

namespace PurpleBuzzProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
       
        public DbSet<OurTeam> OurTeams { get; set; }
        public DbSet<OurWork> OurWorks { get; set; }
    }
}
