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
                Description = "Langage de programmation orienté objet et destiné à développer sur la plateforme Microsoft .NET.",
                Type = SkillType.Technical,
                Level = "Performant",
                WorkingTime = "4 ans",
                Achievements = new List<string> { "recuperation_log_terminaux", "migration_sql", "surveillance_terminaux", "gestion_parc_terminaux", "chambre_agriculture" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 2,
                Name = "android",
                Title = "Android",
                Description = "Système d'exploitation mobile open-source de Google qui équipe la majorité des smartphones et tablettes du marché.",
                Type = SkillType.Technical,
                Level = "Performant",
                WorkingTime = "3 ans",
                Achievements = new List<string> { "surveillance_terminaux", "lecteur_configuration", "wawee" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 3,
                Name = "xamarin",
                Title = "Xamarin",
                Description = "Framework permettant de créer des applications natives pour Android, iOS et macOS en utilisant du code .NET.",
                Type = SkillType.Technical,
                Level = "Compétent",
                WorkingTime = "2 ans",
                Achievements = new List<string> { "chambre_agriculture" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 4,
                Name = "javascript",
                Title = "JavaScript",
                Description = "Souvent abrégé en \"JS\", c'est un langage de script léger, orienté objet, principalement connu comme le langage de script des pages web.",
                Type = SkillType.Technical,
                Level = "Compétent",
                WorkingTime = "2 ans",
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
                Level = "Compétent",
                Achievements = new List<string> { "lecteur_configuration" }
            },
            new Skill
            {
                Id = 6,
                Name = "bash",
                Title = "Bash",
                Type = SkillType.Technical,
                Level = "Compétent",
                Achievements = new List<string> { "lecteur_configuration" }
            },
            new Skill
            {
                Id = 7,
                Name = "php",
                Title = "PHP",
                Type = SkillType.Technical,
                Level = "Compétent",
                Achievements = new List<string> { "still_english", "upsa", "clinique_st_hilaire", "wawee" }
            },
            new Skill
            {
                Id = 8,
                Name = "sql",
                Title = "SQL 📊",
                Description = "Langage qui est utilisé pour communiquer avec des bases de données relationnelles. Il permet entre autre de lire, créer, modifier ou bien supprimer des données.",
                Type = SkillType.Technical,
                Level = "Performant",
                WorkingTime = "4 ans",
                Achievements = new List<string> { "gestion_parc_terminaux", "migration_sql", "recuperation_log_terminaux", "chambre_agriculture", "wawee", "clinique_st_hilaire", "upsa", "still_english" },
                IsWritten = true,
                IsVisible = true
            },
            new Skill
            {
                Id = 9,
                Name = "versionning",
                Title = "Versionning",
                Description = "La gestion de versions consiste à gérer l'ensemble des versions d'un ou plusieurs fichiers.",
                Type = SkillType.Technical,
                Level = "Performant",
                WorkingTime = "4 ans",
                Achievements = new List<string> { "gestion_parc_terminaux", "migration_sql", "recuperation_log_terminaux", "chambre_agriculture", "wawee", "clinique_st_hilaire", "upsa", "still_english", "bureau_etudiant_intech" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill
            {
                Id = 10,
                Name = "communication",
                Title = "Communication",
                Description = "Capacité d’un individu à échanger ou transmettre, que ce soit oralement ou par écrit, une information à une ou plusieurs personnes.",
                Type = SkillType.Human,
                Level = "Performant",
                WorkingTime = "5 ans",
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
                Description = "Capacité d'une personne à récolter et analyser le besoin d'un tiers quelque soit le sujet ou sa forme.",
                Type = SkillType.Human,
                Level = "Compétent",
                WorkingTime = "4 ans",
                Achievements = new List<string>(),
                IsVisible = true,
                IsWritten = true
            },
            new Skill 
            { 
                Id = 12, 
                Name = "travail_equipe", 
                Title = "Travail d'équipe 👨‍👩‍👧‍👦", 
                Description = "Concept dans lequel des personnes vont interagir et s’organiser entre elles afin d’atteindre un objectif commun.",
                Type = SkillType.Human,
                Level = "Performant",
                WorkingTime = "5 ans",
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
                Level = "Compétent",
                Achievements = new List<string>()
            },
            new Skill 
            { 
                Id = 14, 
                Name = "montage_video", 
                Title = "Montage vidéo", 
                Description = "Travail consistant à sélectionner des séquences d'images en vidéo et à les assembler en une suite cohérente ou sous forme d'expression artistique.",
                Type = SkillType.Human,
                Level = "Performant",
                WorkingTime = "5 ans",
                Achievements = new List<string> { "wawee" },
                IsVisible = true,
                IsWritten = true
            },
            new Skill 
            { 
                Id = 15, 
                Name = "gestion_budget", 
                Title = "Gestion de budget", 
                Type = SkillType.Human,
                Level = "Compétent",
                Achievements = new List<string>()
            },
        };
    }
}
