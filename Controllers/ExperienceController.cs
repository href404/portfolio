using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        [Route("experiences")]
        public IActionResult Index() => View();
    }
}
