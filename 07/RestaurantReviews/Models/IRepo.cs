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
        /// Add the Restaurant into the Restaurants table in database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns>Returns the Restaurant which was added</returns>
        T AddRestaurant(T restaurant);
        /// <summary>
        /// Will return all restaurants in the Restaurant.json file
        /// </summary>
        /// <returns>List of all restaurants objects in the collection of Type List<Restaurant></returns>
        List<T> GetAllRestaurants();
        /// <summary>
        /// Removes the the given restaurant from the database by searching for the restaurant by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns the resaturant which is removed from the restanrants table</returns>
        T RemoveRestaurant(string name);
        /// <summary>
        /// Updates the information about the restaurant in the database
        /// </summary>
        /// <param name="restaurant"></param>
        /// <returns>updated restaurant</returns>
        T UpdateRestaurant(T restaurant);

    }
}
