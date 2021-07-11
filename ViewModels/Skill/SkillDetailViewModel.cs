using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillDetailViewModel : BaseSkillViewModel
    {
        public Models.Skill Skill { get; init; }
        public IEnumerable<Models.Achievement> Achievements { get; init; }

    }
}
