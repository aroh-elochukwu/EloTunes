using EloTunes.Models;
using Microsoft.EntityFrameworkCore;

namespace EloTunes.Data
{
    public class ApplicationDbContext: DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Genre> Genres { get; set; }   
        public DbSet<Artist> Artists { get; set; }
       
    }
}
