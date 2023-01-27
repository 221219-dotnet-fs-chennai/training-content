global using Serilog;
using Data;
using System;

namespace UI_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling restaurants from EF Library 
            //Data_EF_DBFirst.IRepo repo = new Data_EF_DBFirst.SqlRepo();
            //var allRestaurants= repo.GetRestaurants();
            //foreach (var restaurant in allRestaurants)
            //{
            //    Console.WriteLine($"{restaurant.Id} {restaurant.Name}");
            //}
            
            // Initialize the logger
            Log.Logger = new LoggerConfiguration()
                            .WriteTo.File(@"..\..\..\Logs\logs.txt", rollingInterval: RollingInterval.Day, rollOnFileSizeLimit: true)
                            .CreateLogger();

            bool repeat = true;
            IMenu menu = new Menu();
            while (repeat)
            {
                Console.Clear();
                menu.Display();
                string ans = menu.UserChoice();
                switch (ans)
                {
                    case "AddRestaurant":
                        Log.Information("Displaying Add restaurant menu to user");
                        menu = new AddRestaurantMenu();
                        break;
                    case "GetAllRestaurants":
                        menu = new GetRestaurantsMenu();
                        break;
                    case "Menu":
                        Log.Information("Displaying Main Menu to user");
                        menu = new Menu();
                        break;
                    case "Exit":
                        Log.Information("Exiting application");
                        Log.CloseAndFlush(); //To close our logger resource
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Page does not exist!");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        break;
                }
            }

        }
    }
}