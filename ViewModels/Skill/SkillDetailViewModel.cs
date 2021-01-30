using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillDetailViewModel : BaseDetailViewModel
    {
        public Models.Skill Skill { get; set; }
        public IEnumerable<Models.Achievement> Achievements { get; set; }

        public string GetSkillType()
        {
            if (Skill.Type == Models.SkillType.TECHNICAL) return "Technique";
            if (Skill.Type == Models.SkillType.HUMAN) return "Transverse";
            return "🤷‍♂️";
        }
    }
}
