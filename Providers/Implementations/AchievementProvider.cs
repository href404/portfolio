using Portfolio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Providers.Implementations
{
    public class AchievementProvider : IAchievementProvider
    {
        private readonly IEnumerable<Achievement> achievements = new List<Achievement>
        {
            new Achievement 
            { 
                Id = 1, 
                Name = "gestion_parc_terminaux", 
                Title = "Gestion de parc pour les terminaux", 
                Description = "Application web ayant pour objectif de gérer le parc de terminaux d'INFOMIL.", 
                Client = "INFOMIL", 
                Type = AchievementType.WEB,
                Skills = new List<string> { "javascript", "csharp", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 2, 
                Name = "lecteur_configuration", 
                Title = "Lecteur de configuration pour les bornes", 
                Description = "Application Android permettant la lecture de planche de configuration (code à barre) afin de déployer des usages sur des terminaux.", 
                Client = "INFOMIL", 
                Type = AchievementType.MOBILE,
                Skills = new List<string> { "android", "csharp", "docker", "bash", "sql", "javascript", "versionning" }
            },
            new Achievement 
            { 
                Id = 3, 
                Name = "surveillance_terminaux", 
                Title = "Application mobile de surveillance des terminaux", 
                Description = "Service Android permettant de remonter des informations toutes les x minutes sur les terminaux du parc.", 
                Client = "INFOMIL", 
                Type = AchievementType.MOBILE,
                Skills = new List<string> { "android", "csharp", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 4, 
                Name = "migration_sql", 
                Title = "Migration SQL Server vers PostgreSQL", 
                Description = "Application console visant à migrer la structure et le contenu d'une base de données SQL Server dans une base de données PostgreSQL.", 
                Client = "INFOMIL", 
                Type = AchievementType.RICH_CLIENT,
                Skills = new List<string> { "csharp", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 5, 
                Name = "recuperation_log_terminaux", 
                Title = "Récupération des logs des terminaux", 
                Description = "Application WinForm permettant de récupérer les informations d'un terminal et d'intéragir avec le contenu de carte mémoire notamment dans le cadre de la récupération des logs générés par les applications d'INFOMIL.", 
                Client = "INFOMIL", 
                Type = AchievementType.RICH_CLIENT,
                Skills = new List<string> { "csharp", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 6, 
                Name = "chambre_agriculture", 
                Title = "Application mobile pour la Chambre de l'Agriculture", 
                Description = "Application Android permettant de géolocaliser les agriculteurs et marchés de la marque Bienvenue à la Ferme.", 
                Client = "IN'TECH", 
                Type = AchievementType.MOBILE,
                Skills = new List<string> { "xamarin", "php", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 7, 
                Name = "wawee", 
                Title = "Application mobile pour Wawee", 
                Description = "Application Android permettant la création et le partage d'événement.", 
                Client = "IN'TECH", 
                Type = AchievementType.MOBILE,
                Skills = new List<string> { "android", "php", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 8, 
                Name = "clinique_st_hilaire", 
                Title = "Résérvation pour les médecins de la Clinique Esquirol Saint Hilaire", 
                Description = "Application web permettant aux médecins, le suivi des patients à distance.", 
                Client = "IN'TECH", 
                Type = AchievementType.WEB,
                Skills = new List<string> { "php", "javascript", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 9, 
                Name = "upsa", 
                Title = "Gestionnaire de fichier pour UPSA", 
                Description = "Application web permettant à UPSA de partager leurs fichiers.", 
                Client = "IN'TECH", 
                Type = AchievementType.WEB,
                Skills = new List<string> { "php", "javascript", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 10, 
                Name = "still_english", 
                Title = "Jeu Still English", 
                Description = "Application web permettant de jouer au jeu de plateau Still English dans une version numérique.", 
                Client = "IN'TECH", 
                Type = AchievementType.WEB,
                Skills = new List<string> { "php", "javascript", "sql", "versionning" }
            },
            new Achievement 
            { 
                Id = 11, 
                Name = "bureau_etudiant_intech", 
                Title = "Bureau des étudiants d'IN'TECH", 
                Description = "Application web permettant aux adhérents du bureau des étudiants d'IN'TECH de partager des les futurs événement et informations du campus.", 
                Client = "IN'TECH", 
                Type = AchievementType.WEB,
                Skills = new List<string> { "javascript" }
            },
        };

        public async Task<IEnumerable<Achievement>> GetAchievements() => achievements;
    }
}
