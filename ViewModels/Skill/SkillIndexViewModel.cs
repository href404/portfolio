using System.Collections.Generic;

namespace Portfolio.ViewModels.Skill
{
    public class SkillIndexViewModel
    {
        public IEnumerable<Models.Skill> Techincals { get; set; }
        public IEnumerable<Models.Skill> Humans { get; set; }

    }
}
