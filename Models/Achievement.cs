using System.Collections.Generic;

namespace Portfolio.Models
{
    public class Achievement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public AchievementType Type { get; set; }
        public IEnumerable<string> Skills { get; set; }
    }

    public enum AchievementType
    {
        WEB,
        MOBILE,
        RICH_CLIENT
    }
}
