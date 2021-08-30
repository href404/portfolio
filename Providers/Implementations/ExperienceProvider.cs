using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Providers.Implementations
{
    public class ExperienceProvider : IExperienceProvider
    {
        private readonly IEnumerable<Experience> _experiences = new List<Experience>
        {
            new Experience 
            { 
                Id = 1, 
                Name = "bac-pro", 
                Title = "Baccalauréat Professionnel", 
                Entity = "CFA Marmande",
                Period = "Septembre 2014 à Septembre 2016",
                Description = "Après des problèmes de santé qui ont intérommpu mes études, le CFA de Marmande m'a permis de me relancer via une alternance dans le commerce.", 
                Type = ExperienceType.School,
                IsVisible = true,
                IsWritten = false
            },
            new Experience 
            { 
                Id = 2, 
                Name = "intech-sud", 
                Title = "INTECH Sud", 
                Entity = "Groupe AEN",
                Period = "Septembre 2016 à Mars 2019",
                Description = "Je rejoins l'école INTECH Sud qui m'a permis de faire mes premiers pas dans l'informatique.", 
                Type = ExperienceType.School,
                IsVisible = true,
                IsWritten = false
            },
            new Experience 
            { 
                Id = 3, 
                Name = "bachelor-informatique", 
                Title = "Bachelor Informatique", 
                Entity = "Groupe AEN",
                Period = "Septembre 2019",
                Description = "Suite à mon stage de 6 mois en entreprise et aux compétences acquises durant les 2 ans et demi passés à l'école IN'TECH Sud.", 
                Type = ExperienceType.School,
                IsVisible = true,
                IsWritten = false
            },
            new Experience 
            { 
                Id = 4, 
                Name = "infomil-stage", 
                Title = "Stage développeur",
                Entity = "INFOMIL",
                Period = "Mars 2019 à Septembre 2019",
                Description = "SS2I Toulousaine, j’ai intégré le pôle étude et développement durant un stage de 6 mois.", 
                Type = ExperienceType.Company,
                IsVisible = true,
                IsWritten = false
            },
            new Experience 
            { 
                Id = 5, 
                Name = "infomil-alternance", 
                Title = "Alternant développeur", 
                Entity = "INFOMIL",
                Period = "Septembre 2019 à aujourd'hui",
                Description = "Je continue mon cursus dans la même entreprise ainsi que dans la même équipe.", 
                Type = ExperienceType.Company,
                IsVisible = true,
                IsWritten = false
            },
        };

        public async Task<IEnumerable<Experience>> GetExperiences()
        {
            return await Task.Run(() => _experiences.Reverse());
        }
    }
}