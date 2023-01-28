using EF=DataFluentApi;
using Models;
using System;
using System.IO;
using BusinessLogic;

namespace UI_Console
{
    internal class AddRestaurantMenu : IMenu
    {
        private static Restaurant newRestaurant = new Restaurant();
        // reading connection String from a file
        static string conStr = File.ReadAllText("../../../connectionString.txt");

        ILogic repo = new Logic();
        public void Display()
        {
            Console.WriteLine("Enter Pokemon information");
            //Console.WriteLine("[8] Email - " + newRestaurant.Email);
            //Console.WriteLine("[7] Phone - " + newRestaurant.Phone);
            Console.WriteLine("[6] Close time - " + newRestaurant.CloseTime);
            Console.WriteLine("[5] Open time - " + newRestaurant.OpenTime);
            Console.WriteLine("[4] Zipcode - " + newRestaurant.ZipCode);
            Console.WriteLine("[3] Name - " + newRestaurant.Name);
            //Console.WriteLine("[2] Id - " + newRestaurant.Id);
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "Menu";
                case "1":
                    //Exception handling to have a better user experience
                    try
                    {
                        Log.Information("Adding restaurant \n" + newRestaurant);
                        //repo.Add(newRestaurant);
                        Log.Information("Successful at adding Restaurant!");
                    }
                    catch (System.Exception exc)
                    {
                        Log.Error($"Failed to add Restaurant - {exc.Message}");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "Menu";
                //case "2":
                //    Console.WriteLine("Please enter an Id!");
                //    newRestaurant.Id = Convert.ToInt32(Console.ReadLine());
                //    return "AddRestaurant";
                case "3":
                    Console.WriteLine("Please enter a name!");
                    newRestaurant.Name = Console.ReadLine();
                    return "AddRestaurant";
                case "4":
                    Console.WriteLine("Please enter the zipcode!");
                    newRestaurant.ZipCode = Console.ReadLine();
                    return "AddRestaurant";
                case "5":
                    Console.WriteLine("Please enter the Open time");
                    newRestaurant.OpenTime = TimeSpan.Parse(Console.ReadLine());
                    return "AddRestaurant";
                case "6":
                    Console.WriteLine("Please enter the close time");
                    newRestaurant.CloseTime = TimeSpan.Parse(Console.ReadLine());
                    return "AddRestaurant";
                //case "7":
                //    Console.WriteLine("Please enter the Phone");
                //    newRestaurant.Phone = Console.ReadLine();                    
                //    return "AddRestaurant";
                //case "8":
                //    Console.WriteLine("Please enter the Email");
                //    newRestaurant.Email = Console.ReadLine();
                //    return "AddRestaurant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddRestaurant";
            }
        }
    }
}
