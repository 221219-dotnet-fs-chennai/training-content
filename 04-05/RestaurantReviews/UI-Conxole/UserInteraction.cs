using Data;
using System;

namespace UI_Console
{
    class UserInteraction
    {
        static FileRepo file = new FileRepo();
        //Add restaurant by taking input from user

        //read all restaurants
        internal static void GetRestaurants()
        {
            Log.Logger.Information("Fetching all restaurants");
            var restaurants=file.GetAllRestaurants();
            Log.Logger.Information("All restaurants fetched");
            foreach (var restaurant in restaurants)
            {
                Log.Logger.Information(restaurant.Name);
                Console.WriteLine(restaurant.ToString());
            }
        }
    }
}
