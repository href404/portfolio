using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Achievement : Article
    {
        public string Description { get; init; }
        public string Client { get; init; }
        public AchievementType Type { get; init; }
        public IEnumerable<string> Skills { get; init; }
    }

    public enum AchievementType { Web, Mobile, RichClient }
}
