﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Providers;
using Portfolio.ViewModels.Skill;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    [Route("competences")]
    public class SkillController : Controller
    {
        private readonly ISkillProvider _skillProvider;
        private readonly IAchievementProvider _achievementProvider;
        private readonly IWebHostEnvironment _environment;

        public SkillController(
            ISkillProvider skillProvider,
            IAchievementProvider achievementProvider,
            IWebHostEnvironment environment)
        {
            _skillProvider = skillProvider;
            _achievementProvider = achievementProvider;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var skills = await _skillProvider.GetSkills();
            var viewModel = new SkillIndexViewModel
            {
                Techincals = skills.Where(s => s.Type == SkillType.Technical),
                Humans = skills.Where(s => s.Type == SkillType.Human)
            };
            return View(viewModel);
        }

        [Route("{skillName}")]
        public async Task<IActionResult> Detail(string skillName)
        {
            if (string.IsNullOrEmpty(skillName)) 
                return BadRequest("Echec lors de la récupération du nom de la compétence.");

            var skills = await _skillProvider.GetSkills();
            var achievements = await _achievementProvider.GetAchievements();
            var skill = skills.SingleOrDefault(s => s.Name == skillName);

            if (skill == null) return RedirectToAction("Error", "Home");
            
            var skillType = skill.Type == SkillType.Human ? "human" : "technical";
            var pathHtmlFile = Path.Combine(
                _environment.WebRootPath, 
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
