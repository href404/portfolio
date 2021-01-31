using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Providers;
using Portfolio.ViewModels.Achievement;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class AchievementController : Controller
    {
        private readonly IAchievementProvider achievementProvider;
        private readonly ISkillProvider skillProvider;
        private readonly IWebHostEnvironment environment;

        public AchievementController(
            IAchievementProvider achievementProvider,
            ISkillProvider skillProvider,
            IWebHostEnvironment environment)
        {
            this.achievementProvider = achievementProvider;
            this.skillProvider = skillProvider;
            this.environment = environment;
        }

        [Route("realisations")]
        public async Task<IActionResult> Index()
        {
            var achievements = await achievementProvider.GetAchievements();
            var viewModel = new AchievementIndexViewModel { Achievements = achievements };
            return View(viewModel);
        }

        [Route("realisations/{achievementName}")]
        public async Task<IActionResult> Detail(string achievementName)
        {
            if (string.IsNullOrEmpty(achievementName))
                return BadRequest("Echec lors de la récupération du nom de la réalisation.");

            var achievements = await achievementProvider.GetAchievements();
            var skills = await skillProvider.GetSkills();
            var achievement = achievements.SingleOrDefault(a => a.Name == achievementName);

            var pathHtmlFile = Path.Combine(
                environment.WebRootPath,
                "articles",
                "achievements",
                $"{achievement.Name}.html");

            var viewModel = new AchievementDetailViewModel 
            { 
                Achievement = achievement, 
                Skills = skills.Where(s => s.Achievements.Contains(achievement.Name)),
                PathHtmlFile = pathHtmlFile 
            };
            return View(viewModel);
        }
    }
}
