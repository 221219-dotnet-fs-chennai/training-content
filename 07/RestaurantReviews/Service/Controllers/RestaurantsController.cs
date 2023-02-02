using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class RestaurantsController : ControllerBase // controllerbase class has all methods and properties to handle HTTP Requests/responses
    {
        IRestaurantLogic _logic;
        public RestaurantsController(IRestaurantLogic logic)
        {
            _logic = logic;
        }
        [HttpGet("all")]
        public ActionResult Get()
        {
            try
            {
                var restaurants = _logic.GetRestaurants();
                if (restaurants.Count() > 0)
                    return Ok(restaurants);
                else
                    return BadRequest("Seems like your database donot have records for Restaurant Table");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult GetById([FromRoute] int id)
        {
            try
            {
                var search = _logic.GetRestaurantsById(id);
                if (search != null)
                    return Ok(search);
                else
                    return NotFound($"Restaurants with ID {id} not available, please try with different id");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet("zipcode/{zipcode}")]
        public ActionResult GetByZipcode([FromRoute]string zipcode)
        {
            try
            {
                var search = _logic.GetRestaurantsByZipcode(zipcode);
                if (search.Count() > 0)
                    return Ok(search);
                else
                    return NotFound($"Restaurannts in the zipcode {zipcode} not available, please try with different zipcode");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        
        [HttpPost("Add")] // Trying to create a resource on the server
        public ActionResult Add([FromBody]Restaurant r)
        {
            try
            {
                var addedRestaurant = _logic.AddRestaurant(r);
                return CreatedAtAction("Add",addedRestaurant); //201 -> Serialization of restaurant object
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("Delete/{name}")]
        public ActionResult Delete(string name)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    var rest = _logic.RemoveRestaurantByName(name);
                    if (rest != null)
                        return Ok(rest);
                    else
                        return NotFound();
                }
                else
                    return BadRequest("Please add a valid restaurant name to be deleted");
                
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
        [HttpPut("modify/{name}")]
        public ActionResult Update([FromRoute]string name, [FromBody]Restaurant r)
        {
            try
            {
                if (!string.IsNullOrEmpty(name))
                {
                    _logic.UpdateRestaurant(name,r);
                    return Ok(r);
                }
                else
                    return BadRequest($"something wrong with {r.Name} input, please try again!");
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
