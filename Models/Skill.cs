using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Skill : Article
    {
        public SkillType Type { get; init; }
        public double Level { get; init; }
        public IEnumerable<string> Achievements { get; init; }
    }

    public enum SkillType { Technical, Human }
}
