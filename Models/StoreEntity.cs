using Microsoft.EntityFrameworkCore;

namespace WebApiProjectMUI_React.Models
{
    public class StoreEntity:DbContext
    {
        public StoreEntity(DbContextOptions options):base(options)
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categor { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrederDetails> orederDetails { get; set; }    
    }
}
