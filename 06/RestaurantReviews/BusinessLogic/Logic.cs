using Models;
using EF = DataFluentApi;

namespace BusinessLogic
{
    public class Logic : ILogic
    {
        IRepo<EF.Entities.Restaurant> repo;
        public Logic()
        {
            repo = new EF.EFRepo();
        }
        public IEnumerable<Restaurant> GetRestaurants()
        {
          return Mapper.Map(repo.GetAllRestaurants());
        }

        public IEnumerable<Restaurant> GetRestaurantsByZipcode(string zipcode)
        {
            throw new NotImplementedException();
            //var query = from r in repo.GetAllRestaurants()
            //            where r.ZipCode == zipcode.Trim()
            //            select r;
            //return query.ToList();
            ////return repo.GetAllRestaurants().Where(r=>r.ZipCode == zipcode);
        }
    }
}