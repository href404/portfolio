using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    [Route("contact")]
    public class ContactController : Controller
    {
        public IActionResult Index() => View();
    }
}