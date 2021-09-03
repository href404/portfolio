using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Skill : Article
    {
        public SkillType Type { get; init; }
        public string Level { get; init; }
        public string WorkingTime { get; set; }
        public IEnumerable<string> Achievements { get; init; }
    }

    public enum SkillType { Technical, Human }
}
