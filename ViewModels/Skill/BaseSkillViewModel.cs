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
        
        public int GetLevelRounded(Models.Skill skill) => Convert.ToInt32(Math.Floor(skill.Level));
        public bool IsLevelDecimal(Models.Skill skill) => skill.Level % 1 != 0;
        public int GetEmptyStarsCount(Models.Skill skill) => Convert.ToInt32(Math.Floor(MaxStars - skill.Level));
    }
}