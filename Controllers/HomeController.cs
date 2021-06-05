using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        
        [Route("/error")]
        public IActionResult Error() => View();
    }
}
