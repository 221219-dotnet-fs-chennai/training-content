using DataFluentApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFluentApi
{
    public class ReviewRepo : IReviewRepo
    {
        private readonly RestaurantDbContext _context;
        public ReviewRepo(RestaurantDbContext context)
        {
            _context = context;
        }
        public Review AddReview(Restaurant restaurant,Review review)
        {
            _context.Reviews.Add(
                new Review()
                {
                    RestaurantId = restaurant.Id,
                    AmbienceRating = review.AmbienceRating,
                    Comment = review.Comment,
                    ServiceRating = review.ServiceRating,
                    TasteRating = review.TasteRating
                }

                );
            _context.SaveChanges();
            return review;
        }

        public List<Review> GetReviews(Entities.Restaurant restaurant)
        {
            return _context.Reviews.Where(x=>x.RestaurantId == restaurant.Id).ToList();
        }
    }
}
