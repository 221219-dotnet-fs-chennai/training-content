using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Console
{
    /*
     MainMenu inherits IMenu interface but since it is a class it needs to give actual implementation details to the methods
     stated inside of the interface
 */
    internal class Menu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Restaurant reviews!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[2] Look for Restaurants");
            Console.WriteLine("[1] Add a new Restaurant");
            Console.WriteLine("[0] Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            //Switch cases are just useful if you are doing a bunch of comparison
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddRestaurant";
                case "2":
                    return "GetAllRestaurants";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "Menu";
            }
        }
    }
}
