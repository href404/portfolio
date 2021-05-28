using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Achievement
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public string Client { get; init; }
        public AchievementType Type { get; init; }
        public IEnumerable<string> Skills { get; init; }
    }

    public enum AchievementType { Web, Mobile, RichClient }
}
