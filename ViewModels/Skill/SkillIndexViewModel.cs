using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillIndexViewModel
    {
        public IEnumerable<Models.Skill> Techincals { get; init; }
        public IEnumerable<Models.Skill> Humans { get; init; }

    }
}
