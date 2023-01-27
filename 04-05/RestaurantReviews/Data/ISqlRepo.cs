using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal interface ISqlRepo
    {
        Task<List<Restaurant>> GetAllRestaurantsAsync();
        List<Restaurant> GetAllRestaurantsDisconnected();
    }
}
