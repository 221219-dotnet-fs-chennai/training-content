using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IReviewLogic _reviewLogic;
        private readonly IRestaurantLogic _restaurantLogic;
        public ReviewsController(IReviewLogic reviewLogic, IRestaurantLogic restaurantLogic)
        {
            _reviewLogic = reviewLogic;
            _restaurantLogic = restaurantLogic;
        }
        [HttpPost("AddReview")]
        public ActionResult Post(int restaurantId, [FromBody]Review newReview)
        {
            var restaurantSearchedById = _restaurantLogic.GetRestaurantsById(restaurantId);

            return Created($"/api/Restaurants/{restaurantId}/Reviews",
                _reviewLogic.AddReview(
                        restaurantSearchedById, newReview 
                        ));
        }

        //task 
        //implement the getReviews 
        [HttpGet]
        public ActionResult Get(int restaurantId) 
        {
            var restaurantSearchedById = _restaurantLogic.GetRestaurantsById(restaurantId);
            return Ok(_reviewLogic.GetReviews(restaurantSearchedById));
        }
    }
}
