namespace Portfolio.Models
{
    public class Experience : Article
    {
        public ExperienceType Type { get; init; }
        public string Entity { get; set; }
        public string Period { get; set; }
    }
    
    public enum ExperienceType { Company, School }
}