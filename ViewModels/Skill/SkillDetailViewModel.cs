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
    }
}
