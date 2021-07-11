using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillIndexViewModel : BaseSkillViewModel
    {
        public IEnumerable<Models.Skill> Technicals { get; init; }
        public IEnumerable<Models.Skill> Humans { get; init; }
    }
}
