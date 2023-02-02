using Models;
namespace BusinessLogic
{
    public interface IReviewLogic
    {
        
        Review AddReview(Restaurant restaurant,Review review);
        List<Review> GetReviews(Restaurant restaurant);
    }
}
