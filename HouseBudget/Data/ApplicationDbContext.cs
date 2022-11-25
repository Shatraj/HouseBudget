using Microsoft.EntityFrameworkCore;
namespace HouseBudget.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Entry> Entries { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
    }
}
