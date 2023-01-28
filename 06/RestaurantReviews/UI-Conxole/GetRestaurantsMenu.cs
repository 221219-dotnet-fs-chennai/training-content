using BusinessLogic;
using System;
using System.IO;
using System.Linq;

namespace UI_Console
{
    internal class GetRestaurantsMenu : IMenu
    {
        // reading connection String from a file
        static string conStr = File.ReadAllText("../../../connectionString.txt");
      
        //IRepo repo = new SqlRepo(conStr);
        ILogic repo=new Logic();
        public void Display()
        {
            Console.WriteLine("Please select an option to filter the Restaurant reviews database");
            Console.WriteLine("[2] Search restaurants by zipcode");
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
                    var listOfRestaurant = repo.GetRestaurants();
                    Log.Information($"Got list of {listOfRestaurant.Count()} restaurants");
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
                case "2":
                    //Logic to display the result
                    Log.Information("Search for Restaurants by zipcode");
                    Console.WriteLine("Please enter the zipcode for the restaurants search");
                    string zipcode = Console.ReadLine();
                    var rst = repo.GetRestaurantsByZipcode(zipcode);
                    Log.Information($"Got list of {rst.Count()} restaurants");
                    Log.Information("Reading restaurants about to start");
                    foreach (var r in rst)
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
