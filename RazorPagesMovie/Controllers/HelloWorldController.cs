using Microsoft.AspNetCore.Mvc;

namespace RazorPagesMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}