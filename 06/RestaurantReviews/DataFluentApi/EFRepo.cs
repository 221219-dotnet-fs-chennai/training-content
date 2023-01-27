using DataFluentApi.Entities;
using Models;

namespace DataFluentApi
{
    public class EFRepo : IRepo<Entities.Restaurant>
    {
        RestaurantDbContext context = new RestaurantDbContext();
        public Entities.Restaurant Add(Entities.Restaurant restaurant)
        {
            context.Add(restaurant);// no need to add any sql INSERT query just call Add method and it will create INSERT query behind the scenes
            context.SaveChanges(); // this method will fire the query to DB and persist the changes
            return restaurant;
        }

        public List<Entities.Restaurant> GetAllRestaurants()
        {
            return context.Restaurants.ToList();
        }
    }
}