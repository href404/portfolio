using System;
using Portfolio.Models;

namespace Portfolio.ViewModels.Experience
{
    public class ExperienceDetailViewModel : BaseDetailViewModel
    {
        public Models.Experience Experience { get; init; }

        public string GetExperienceType()
        {
            return Experience.Name switch
            {
                "intech-sud" => "Étudiant",
                "infomil-stage" => "Stagiaire",
                "infomil-alternance" => "Apprenti Expert Logiciel",
                _ => "Inconnu"
            };
        }
    }
}