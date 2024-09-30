using Microsoft.EntityFrameworkCore;

namespace Tourism.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options): base(options) { }   
        public DbSet<User> Users { get; set; }  
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Destination> Destination { get; set; } 
        public DbSet<Users> Favorites { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Offer> offers { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<User_Destination> user_Destinations { get; set; }



        
    }
}
