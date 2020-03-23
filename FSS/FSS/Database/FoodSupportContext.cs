using Microsoft.EntityFrameworkCore;

namespace FSS.Data
{
    public class FoodSupportContext : DbContext   
    {
        public FoodSupportContext(DbContextOptions<FoodSupportContext> options) : base(options)
        {
            
        }
        
        public DbSet<Request> Requests { get; set; }
        
        public DbSet<Helper> Helpers { get; set; }
    }
}
