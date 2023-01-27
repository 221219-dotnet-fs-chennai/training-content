using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;// library to serialize and deserialize objects to json or vice-versa
using System.Text.Json.Serialization;
using Models;
using System.IO;

namespace Data
{
    public class FileRepo : IRepo
    {
        private string _filePath = "../../../../Data/FileDatabase/";
        private string _jsonString;
        /// <summary>
        /// This method will add new restaurant into existing Json File database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns>newly added restaurant is returned</returns>
        public Restaurant Add(Restaurant restaurant)
        {
            string path = _filePath + "Restaurant.json";
            List<Restaurant> listOfRestaurants = GetAllRestaurants();
            listOfRestaurants.Add(restaurant);
            var options = new JsonSerializerOptions() { 
                WriteIndented = true
            };
            _jsonString = JsonSerializer.Serialize(listOfRestaurants, options);

            File.WriteAllText(path, _jsonString);

            return restaurant;
        }
        /// <summary>
        /// this will read the Restaurant.json file and deserialize the Restaurants to C# objects (List<Restaurants>)
        /// </summary>
        /// <returns>Deserialized json string to C# object</returns>
        public List<Restaurant> GetAllRestaurants()
        {
            _jsonString=File.ReadAllText(_filePath + "Restaurant.json");
            
            //Deserialize the json string to C# object
            return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);
        }
    }
}
