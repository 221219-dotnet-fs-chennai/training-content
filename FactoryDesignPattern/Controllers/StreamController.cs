using FactoryDesignPattern.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FactoryDesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamController : ControllerBase
    {
        private readonly StreamFactory streamFactory;
        public StreamController(StreamFactory streamFactory)
        {
            this.streamFactory = streamFactory;
        }

        [HttpGet("movies/{userchoice}")]
        public IEnumerable<string> GetMovies(string userchoice)
        {
            return streamFactory.GetStreamService(userchoice).ShowMovies();
        }
    }
}
