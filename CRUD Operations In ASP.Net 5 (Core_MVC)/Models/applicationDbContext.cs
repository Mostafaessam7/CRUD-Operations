using Microsoft.EntityFrameworkCore;

namespace CRUD_Operations_In_ASP.Net_5__Core_MVC_.Models
{
    public class applicationDbContext : DbContext
    {
        public applicationDbContext(DbContextOptions<applicationDbContext> options) : base(options) { }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }



    }
}
