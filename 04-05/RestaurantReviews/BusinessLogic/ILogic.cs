using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface ILogic
    {
        /// <summary>
        /// This method will return all the restaurants been queried from the Data Logic
        /// </summary>
        /// <returns></returns>
        IEnumerable<Restaurant> GetRestaurants();
        /// <summary>
        /// This will fetch all the restaurants from the Data layer and then filter it by zipocode
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns>IEnumerable<Restaurants></Restaurants></returns>
        IEnumerable<Restaurant> GetRestaurantsByZipcode(string zipcode);
    }
}
