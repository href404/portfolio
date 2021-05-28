using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Skill
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Title { get; init; }
        public SkillType Type { get; init; }
        public IEnumerable<string> Achievements { get; init; }
    }

    public enum SkillType { Technical, Human }
}
