using HelloRESTFulApi.Models;

namespace HelloRESTFulApi
{
    public class DummyData
    {
        public static List<Restaurant> restaurants = new List<Restaurant>() {
            new Restaurant() { Id = 1,Name = "Chipotle",Cuisine = "Mexican",Zipcode = "20190"},
            new Restaurant() { Id = 2,Name = "Taco Bell",Cuisine = "Tex Mex",Zipcode = "60130"},
            new Restaurant() { Id = 3,Name = "Udippi",Cuisine = "South India",Zipcode = "600001"},
            new Restaurant() { Id = 4,Name = "Pind Baluch",Cuisine = "Punjabi",Zipcode = "110110" }
            };
        public static List<Restaurant> GetRestaurants()
        {
            return restaurants;
        }

        public static Restaurant AddRestaurant(Restaurant r)
        {
            restaurants.Add(r);
            return r;
        }

        public static string RemoveRestaurant(int id)
        {
            var restaurantTobeDeleted = restaurants.Where(x => x.Id == id).FirstOrDefault();
            restaurants.Remove(restaurantTobeDeleted);
            return $"Deleted {restaurantTobeDeleted.ToString}";
        }
    }
}
