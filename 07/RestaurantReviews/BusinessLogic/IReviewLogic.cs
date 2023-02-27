using Models;
namespace BusinessLogic
{
    public interface IReviewLogic
    {
        
        Review AddReview(Restaurant restaurant,Review review);
        IEnumerable<Review> GetReviews(Restaurant restaurant);
    }
}
