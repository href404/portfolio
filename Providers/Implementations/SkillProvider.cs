using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Providers.Implementations
{
    public class SkillProvider : ISkillProvider
    {
        public async Task<IEnumerable<Skill>> GetSkills() => await Task.Run(() => _skills.Where(s => s.IsVisible));

        private readonly IEnumerable<Skill> _skills = new List<Skill>
        {
            new Skill
            {
                Id = 1,
                Name = "csharp",
                Title = "C#",
                Type = SkillType.Technical,
                Level = 4.5,
                Achievements = new List<string> { "recuperation_log_terminaux", "migration_sql", "surveillance_terminaux", "gestion_parc_terminaux", "chambre_agriculture" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 2,
                Name = "android",
                Title = "Android",
                Type = SkillType.Technical,
                Level = 4,
                Achievements = new List<string> { "surveillance_terminaux", "lecteur_configuration", "wawee" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 3,
                Name = "xamarin",
                Title = "Xamarin",
                Type = SkillType.Technical,
                Level = 3,
                Achievements = new List<string> { "chambre_agriculture" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 4,
                Name = "javascript",
                Title = "JavaScript",
                Type = SkillType.Technical,
                Level = 3,
                Achievements = new List<string> { "gestion_parc_terminaux", "lecteur_configuration", "clinique_st_hilaire", "upsa", "still_english", "bureau_etudiant_intech" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 5,
                Name = "docker",
                Title = "Docker 🐋",
                Type = SkillType.Technical,
                Level = 2,
                Achievements = new List<string> { "lecteur_configuration" }
            },
            new Skill
            {
                Id = 6,
                Name = "bash",
                Title = "Bash",
                Type = SkillType.Technical,
                Level = 2,
                Achievements = new List<string> { "lecteur_configuration" }
            },
            new Skill
            {
                Id = 7,
                Name = "php",
                Title = "PHP",
                Type = SkillType.Technical,
                Level = 2.5,
                Achievements = new List<string> { "still_english", "upsa", "clinique_st_hilaire", "wawee" }
            },
            new Skill
            {
                Id = 8,
                Name = "sql",
                Title = "SQL 📊",
                Type = SkillType.Technical,
                Level = 4,
                Achievements = new List<string> { "gestion_parc_terminaux", "migration_sql", "recuperation_log_terminaux", "chambre_agriculture", "wawee", "clinique_st_hilaire", "upsa", "still_english" },
                IsWritten = true,
                IsVisible = true
            },
            new Skill
            {
                Id = 9,
                Name = "versionning",
                Title = "Versionning 🗄",
                Type = SkillType.Technical,
                Level = 4.5,
                Achievements = new List<string> { "gestion_parc_terminaux", "migration_sql", "recuperation_log_terminaux", "chambre_agriculture", "wawee", "clinique_st_hilaire", "upsa", "still_english", "bureau_etudiant_intech" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 10,
                Name = "communication",
                Title = "Communication",
                Type = SkillType.Human,
                Level = 4,
                Achievements = new List<string> 
                { 
                    "bureau_etudiant_intech", 
                    "still_english", 
                    "upsa", 
                    "clinique_st_hilaire", 
                    "wawee", 
                    "chambre_agriculture", 
                    "recuperation_log_terminaux", 
                    "migration_sql",
                    "surveillance_terminaux",
                    "lecteur_configuration",
                    "gestion_parc_terminaux"
                },
                IsWritten = true,
                IsVisible = true
            },
            new Skill 
            { 
                Id = 11, 
                Name = "contact_client", 
                Title = "Contact client", 
                Type = SkillType.Human,
                Level = 3,
                Achievements = new List<string>(),
                IsVisible = true
            },
            new Skill 
            { 
                Id = 12, 
                Name = "travail_equipe", 
                Title = "Travail d'équipe 👨‍👩‍👧‍👦", 
                Type = SkillType.Human,
                Level = 4,
                Achievements = new List<string> 
                { 
                    "bureau_etudiant_intech", 
                    "still_english", 
                    "upsa", 
                    "clinique_st_hilaire", 
                    "wawee", 
                    "chambre_agriculture", 
                    "recuperation_log_terminaux", 
                    "migration_sql",
                    "surveillance_terminaux",
                    "lecteur_configuration",
                    "gestion_parc_terminaux"
                },
                IsWritten = true,
                IsVisible = true
            },
            new Skill 
            { 
                Id = 13, 
                Name = "formation", 
                Title = "Formation", 
                Type = SkillType.Human,
                Level = 2.5,
                Achievements = new List<string>()
            },
            new Skill 
            { 
                Id = 14, 
                Name = "montage_video", 
                Title = "Montage vidéo", 
                Type = SkillType.Human,
                Level = 3.5,
                Achievements = new List<string>(),
                IsVisible = true
            },
            new Skill 
            { 
                Id = 15, 
                Name = "gestion_budget", 
                Title = "Gestion de budget", 
                Type = SkillType.Human,
                Level = 2,
                Achievements = new List<string>()
            },
        };
    }
}
