using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Providers;
using Portfolio.ViewModels.Achievement;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    [Route("realisations")]
    public class AchievementController : Controller
    {
        private readonly IAchievementProvider _achievementProvider;
        private readonly ISkillProvider _skillProvider;
        private readonly IWebHostEnvironment _environment;

        public AchievementController(
            IAchievementProvider achievementProvider,
            ISkillProvider skillProvider,
            IWebHostEnvironment environment)
        {
            _achievementProvider = achievementProvider;
            _skillProvider = skillProvider;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var achievements = await _achievementProvider.GetAchievements();
            var viewModel = new AchievementIndexViewModel { Achievements = achievements };
            return View(viewModel);
        }

        [Route("{achievementName}")]
        public async Task<IActionResult> Detail(string achievementName)
        {
            if (string.IsNullOrEmpty(achievementName))
                return BadRequest("Echec lors de la récupération du nom de la réalisation.");

            var achievements = await _achievementProvider.GetAchievements();
            var skills = await _skillProvider.GetSkills();
            var achievement = achievements.SingleOrDefault(a => a.Name == achievementName);
            
            if (achievement == null) return RedirectToAction("Error", "Home");
            
            var pathHtmlFile = Path.Combine(
                _environment.WebRootPath,
                "articles",
                "achievements",
                $"{achievement.Name}.html");

            var viewModel = new AchievementDetailViewModel 
            { 
                Achievement = achievement, 
                Skills = skills.Where(s => s.Achievements.Contains(achievement.Name)),
                PathHtmlFile = pathHtmlFile,
                WebRootPath = _environment.WebRootPath
            };
            return View(viewModel);
        }
    }
}
