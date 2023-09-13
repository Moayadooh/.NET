using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Disable "Lazy Loading"
            //ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Book> Books { get; set; }
    }
}
