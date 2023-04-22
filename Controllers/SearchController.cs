using Microsoft.AspNetCore.Mvc;

namespace TestApplication.Controllers
{
    [Route("/search")]
    public class SearchController : Controller
    {
        [HttpPost]
        public IActionResult PrintSearchParameters(string prefix, string location)
        {
            Console.WriteLine($"Successfully sent data to the backend. Prefix: {prefix} Location: {location}");
            return Ok();
        }
    }
}
