using Models;

namespace Data_CodeFirst
{
    public class EFRepo : IRepo<Restaurant>
    {
        private readonly  RestaurantDbContext _context;
        public EFRepo(RestaurantDbContext context)
        {
            _context = context;
        }
        public Restaurant AddRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.ToList();
        }

        public Restaurant RemoveRestaurant(string name)
        {
            throw new NotImplementedException();
        }

        public Restaurant UpdateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
