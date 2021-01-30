using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Providers;
using Portfolio.ViewModels.Skill;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillProvider skillProvider;
        private readonly IAchievementProvider achievementProvider;
        private readonly IHostingEnvironment environment;

        public SkillController(
            ISkillProvider skillProvider,
            IAchievementProvider achievementProvider,
            IHostingEnvironment environment)
        {
            this.skillProvider = skillProvider;
            this.achievementProvider = achievementProvider;
            this.environment = environment;
        }

        [Route("competences")]
        public async Task<IActionResult> Index()
        {
            var skills = await skillProvider.GetSkills();
            var viewModel = new SkillIndexViewModel
            {
                Techincals = skills.Where(s => s.Type == SkillType.TECHNICAL),
                Humans = skills.Where(s => s.Type == SkillType.HUMAN)
            };
            return View(viewModel);
        }

        [Route("competences/{skillName}")]
        public async Task<IActionResult> Detail(string skillName)
        {
            if (string.IsNullOrEmpty(skillName)) 
                return BadRequest("Echec lors de la récupération du nom de la compétence.");

            var skills = await skillProvider.GetSkills();
            var achievements = await achievementProvider.GetAchievements();
            var skill = skills.SingleOrDefault(s => s.Name == skillName);

            var skillType = skill.Type == SkillType.HUMAN ? "human" : "technical";
            var pathHtmlFile = Path.Combine(
                environment.WebRootPath, 
                "articles", 
                "skills", 
                skillType, 
                $"{skill.Name}.html");

            var viewModel = new SkillDetailViewModel 
            { 
                Skill = skill, 
                Achievements = achievements.Where(a => a.Skills.Contains(skill.Name)),
                PathHtmlFile = pathHtmlFile 
            };
            return View(viewModel);
        }
    }
}
