using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public interface IRepo<T>
    {
        /// <summary>
        /// Add the Restaurant into the Restaurant.json File
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns>Returns the Restaurant which was added</returns>
        T Add(T restaurant);
        /// <summary>
        /// Will return all restaurants in the Restaurant.json file
        /// </summary>
        /// <returns>List of all restaurants objects in the collection of Type List<Restaurant></returns>
        List<T> GetAllRestaurants();
      
    }
}
