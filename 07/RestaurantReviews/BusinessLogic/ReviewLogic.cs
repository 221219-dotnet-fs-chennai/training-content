using DataFluentApi;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ReviewLogic : IReviewLogic
    {
        private readonly IReviewRepo _repo;
        public ReviewLogic(IReviewRepo repo)
        {
            _repo = repo;
        }
        public Review AddReview(Restaurant restaurant, Review review)
        {
            return Mapper.Map(_repo.AddReview(Mapper.Map(restaurant),Mapper.Map(review)));
        }

        public List<Review> GetReviews(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
}
