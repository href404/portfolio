using System;

namespace Portfolio.ViewModels.Skill
{
    public class BaseSkillViewModel : BaseDetailViewModel
    {
        private const int MaxStars = 5;

        public string GetSkillType(Models.Skill skill)
        {
            return skill.Type switch
            {
                Models.SkillType.Technical => "Technique",
                Models.SkillType.Human => "Transverse",
                _ => "🤷‍♂️"
            };
        }
    }
}