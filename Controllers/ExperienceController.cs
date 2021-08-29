using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    [Route("experiences")]
    public class ExperienceController : Controller
    {
        public IActionResult Index() => View();
        
        [Route("{experienceName}")]
        public IActionResult Detail(string experienceName) => View();
    }
}
