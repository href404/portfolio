using System;
using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillDetailViewModel : BaseDetailViewModel
    {
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

        public int GetLevelRounded() => Convert.ToInt32(Skill.Level);
        public bool IsLevelDecimal() => Skill.Level % 1 != 0;
        public int GetEmptyStarsCount() => Skill.Level > 4 ? 0 : 5 - GetLevelRounded();
    }
}
