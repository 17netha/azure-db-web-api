using Microsoft.EntityFrameworkCore;

namespace azure_db_web_api.Controllers
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions dbContextOptions):base(dbContextOptions) { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }
    }
}