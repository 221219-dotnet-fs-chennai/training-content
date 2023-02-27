using Data = DataFluentApi.Entities;
using codefirst = Data_CodeFirst;
namespace BusinessLogic
{
    /// <summary>
    /// We are using Mapper class to convert models to Entity models 
    /// </summary>
    public class Mapper
    {

        public static Models.Review Map(Data.Review review)
        {
            return new Models.Review() {
                Id = review.Id,
                AmbienceRating = review.AmbienceRating,
                Comment = review.Comment,
                OverallRating = review.OverallRating,
                RestaurantId = review.RestaurantId ,
                ServiceRating = review.ServiceRating,
                TasteRating = review.TasteRating
            };
        }
        public static Data.Review Map(Models.Review review)
        {
            return new Data.Review()
            {
                Id = review.Id,
                AmbienceRating = review.AmbienceRating,
                Comment = review.Comment,
                OverallRating = review.OverallRating,
                RestaurantId = review.RestaurantId,
                ServiceRating = review.ServiceRating,
                TasteRating = review.TasteRating
            };
        }
        /// <summary>
        /// This method converts Data's Restaurant object to Models' Restaurant Entity
        /// </summary>
        /// <param name="r"></param>
        /// <returns>Models.Restaurant</returns>
        public static Models.Restaurant Map(codefirst.Restaurant r)
        {
            return new Models.Restaurant()
            {
                Id = r.Id,
                Name = r.Name,
                CloseTime = Validation.HandleTimeSpanNulls(r.CloseTime),
                Cuisine = r.Cuisine,
                OpenTime = Validation.HandleTimeSpanNulls(r.OpenTime),
                Email = r.Email,
                Phone = r.Phone,
                Website = r.Website,
                ZipCode = r.Zipcode
            };
        }
        /// <summary>
        /// This method converts Data's Restaurant object to Models' Restaurant Entity
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
        //task
        public static IEnumerable<Models.Review> Map(IEnumerable<Data.Review> reviews)
        {
            return reviews.Select(Map);
        }
        /// <summary>
        /// This method converts Models' Restaurant object to Entity Framework Restaurant Entity in DataLayer
        /// </summary>
        /// <param name="r"></param>
        /// <returns>Data.Restaurant</returns>
        public static Data.Restaurant Map(Models.Restaurant r)
        {
            return new Data.Restaurant()
            {
                Id = r.Id,
                Name = r.Name,
                CloseTime = Validation.StringToTime(r.CloseTime.ToString()),
                Cuisine = r.Cuisine,
                OpenTime = Validation.StringToTime(r.OpenTime.ToString()),
                Email = r.Email,
                Phone = r.Phone,
                Website = r.Website,
                Zipcode = r.ZipCode
            };
        }
        /// <summary>
        /// This method converts Models' Restaurant object to Entity Framework Restaurant Entity in DataLayer
        /// </summary>
        /// <param name="r"></param>
        /// <returns>Data.Restaurant</returns>
        public static codefirst.Restaurant Map(Models.Restaurant r, string s)
        {
            return new codefirst.Restaurant()
            {
                Id = r.Id,
                Name = r.Name,
                CloseTime = Validation.StringToTime(r.CloseTime.ToString()),
                Cuisine = r.Cuisine,
                OpenTime = Validation.StringToTime(r.OpenTime.ToString()),
                Email = r.Email,
                Phone = r.Phone,
                Website = r.Website,
                Zipcode = r.ZipCode
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
        /// <summary>
        /// This method converts Models' collection of Restaurant object to Entity Framework collection of Restaurant Entity
        /// </summary>
        /// <param name="restaurants"></param>
        /// <returns>IEnumerable<Models.Restaurant></returns>
        public static IEnumerable<Models.Restaurant> Map(IEnumerable<codefirst.Restaurant> restaurants)
        {
            return restaurants.Select(Map);
        }


    }
}
