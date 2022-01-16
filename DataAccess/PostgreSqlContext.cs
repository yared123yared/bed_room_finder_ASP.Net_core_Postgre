using Restaurant.Models;
using Microsoft.EntityFrameworkCore;
namespace Restaurant.DataAccess  
{  
    public class PostgreSqlContext: DbContext  
    {  
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options) : base(options)  
        {  
        }  
  
        public DbSet<Restaurant.Models.Restaurant> restaurant { get; set; }  
        public DbSet<SmallStarRestaurant> smallStarRestaurant { get; set; }  
        // public DbSet<MediumStarRestaurant> mediumStarRestaurants { get; set; }  
        // public DbSet<HighStarRestaurant> highStarRestaurants { get; set; }  
  
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
  
        public override int SaveChanges()  
        {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }  
    }  
}