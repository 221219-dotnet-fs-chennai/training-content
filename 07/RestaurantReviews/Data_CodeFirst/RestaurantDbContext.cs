using Microsoft.EntityFrameworkCore;

namespace Data_CodeFirst
{
    public class RestaurantDbContext:DbContext
    {
        public RestaurantDbContext():base()
        {

        }
        public RestaurantDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // using Has Data we are trying to add some dummy seed data
            var restaurant=modelBuilder.Entity<Restaurant>().HasData(new Restaurant() {Id=1, Name="Chipotle", Cuisine="Mexican", Zipcode="110110" });

            var review = modelBuilder.Entity<Review>().HasData(new Review() { Id = 1, RestaurantId = 1, Comment = "Good food good vibe", AmbienceRating = 4, ServiceRating = 3, TasteRating = 5 });

            //restaurant.HasKey(x => x.Id);
            //restaurant.HasMany(x => x.Reviews);

        }
    }
}
