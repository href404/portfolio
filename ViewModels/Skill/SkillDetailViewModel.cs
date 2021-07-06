using System;
using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillDetailViewModel : BaseDetailViewModel
    {
        private const int MAX_STARS = 5;
        public Models.Skill Skill { get; init; }
        public IEnumerable<Models.Achievement> Achievements { get; init; }

        public string GetSkillType()
        {
            return Skill.Type switch
            {
                Models.SkillType.Technical => "Technique",
                Models.SkillType.Human => "Transverse",
                _ => "🤷‍♂️"
            };
        }

        public int GetLevelRounded() => Convert.ToInt32(Math.Floor(Skill.Level));
        public bool IsLevelDecimal() => Skill.Level % 1 != 0;
        public int GetEmptyStarsCount() => Convert.ToInt32(Math.Floor(MAX_STARS - Skill.Level));
    }
}
