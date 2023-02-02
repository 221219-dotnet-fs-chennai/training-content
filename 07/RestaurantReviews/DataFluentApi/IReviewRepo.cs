using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFluentApi
{
    public interface IReviewRepo
    {
        List<Entities.Review> GetReviews(Entities.Restaurant restaurant);

        Entities.Review AddReview(Entities.Restaurant restaurant,Entities.Review review);
    }
}
