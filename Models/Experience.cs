namespace Portfolio.Models
{
    public class Experience : Article
    {
        public ExperienceType Type { get; init; }
    }
    
    public enum ExperienceType { Company, School }
}