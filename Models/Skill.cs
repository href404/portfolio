using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public SkillType Type { get; set; }
        public IEnumerable<string> Achievements { get; set; }
    }

    public enum SkillType
    {
        TECHNICAL,
        HUMAN
    }
}
