using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Console
{
    internal class GetRestaurantsMenu : IMenu
    {
        IRepo repo = new SqlRepo();
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the Restaurant reviews database");
            Console.WriteLine("[1] All Restaurants");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    //Logic to display the result
                    Log.Information("Getting all restaurants");
                    var listOfRestaurant = repo.GetAllRestaurants();
                    Log.Information($"Got list of {listOfRestaurant.Count} restaurants");
                    Log.Information("Reading restaurants about to start");
                    foreach (var r in listOfRestaurant)
                    {
                        Console.WriteLine("================");
                        Console.WriteLine(r.ToString());
                    }
                    Log.Information("Reading restaurants ends");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();

                    return "Menu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "GetRestaurants";

            }
        }
    }
}
