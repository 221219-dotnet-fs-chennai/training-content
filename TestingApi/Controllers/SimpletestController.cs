using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpletestController : ControllerBase
    {

        public string check(int id)
        {
            string name;
            if(id==1)
            {
                name = "Jeni";
            }
            else if (id==2)
            {
                name = "kaveri";
            }
            else
            {
                name = "not found";
            }
            return name;
        }
    }
}
