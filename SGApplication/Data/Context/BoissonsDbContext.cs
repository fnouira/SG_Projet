using Microsoft.EntityFrameworkCore;
using SGApplication.Data.Boissons;

namespace SGApplication.Data.Context
{
    public class BoissonsDbContext : DbContext
    {
        public BoissonsDbContext(DbContextOptions<BoissonsDbContext> options):base(options)
        {
            
        }
        public DbSet<BoissonsModel> Boissons { get; set; }
    }
}
