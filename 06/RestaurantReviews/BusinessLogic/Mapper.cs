using Data = DataFluentApi.Entities;
namespace BusinessLogic
{
    /// <summary>
    /// We are using Mapper class to convert models to Entity models 
    /// </summary>
    public class Mapper
    {
        /// <summary>
        /// This method converts Models' Restaurant object to Entity Framework Restaurant Entity
        /// </summary>
        /// <param name="r"></param>
        /// <returns>Models.Restaurant</returns>
        public static Models.Restaurant Map(Data.Restaurant r)
        {
            return new Models.Restaurant()
            {
                Id = r.Id,
                Name = r.Name,
                CloseTime =Validation.HandleTimeSpanNulls(r.CloseTime),
                Cuisine = r.Cuisine,
                OpenTime = Validation.HandleTimeSpanNulls(r.OpenTime),
                Email = r.Email,
                Phone = r.Phone,
                Website = r.Website,
                ZipCode = r.Zipcode
            };
        }
        /// <summary>
        /// This method converts Models' collection of Restaurant object to Entity Framework collection of Restaurant Entity
        /// </summary>
        /// <param name="restaurants"></param>
        /// <returns>IEnumerable<Models.Restaurant></returns>
        public static IEnumerable<Models.Restaurant> Map(IEnumerable<Data.Restaurant> restaurants){
              return restaurants.Select(Map);
        }


    }
}
