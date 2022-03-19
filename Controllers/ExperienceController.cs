using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Providers;
using Portfolio.ViewModels.Experience;

namespace Portfolio.Controllers
{
    [Route("experiences")]
    public class ExperienceController : Controller
    {
        private readonly IExperienceProvider _experienceProvider;
        private readonly IWebHostEnvironment _environment;
        
        public ExperienceController(
            IExperienceProvider experienceProvider,
            IWebHostEnvironment environment)
        {
            _experienceProvider = experienceProvider;
            _environment = environment;
        }
        
        public IActionResult Index() => View();

        [Route("{experienceName}")]
        public async Task<IActionResult> Detail(string experienceName)
        {
            if (string.IsNullOrEmpty(experienceName))
                return BadRequest("Echec lors de la récupération du nom de l'expérience.");

            var experiences = await _experienceProvider.GetExperiences();
            var experience = experiences.SingleOrDefault(a => a.Name == experienceName);
            if (experience == null) return RedirectToAction("Error", "Home");
            
            var pathHtmlFile = Path.Combine(
                _environment.WebRootPath,
                "articles",
                "experiences",
                $"{experience.Name}.html");

            var viewModel = new ExperienceDetailViewModel
            { 
                Experience = experience, 
                PathHtmlFile = pathHtmlFile,
                WebRootPath = _environment.WebRootPath
            };
            return View(viewModel);
        }
    }
}
