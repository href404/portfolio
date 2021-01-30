namespace Portfolio.ViewModels.Achievement
{
    public class BaseRealisationViewModel : BaseDetailViewModel
    {
        public string GetAchievementTypeIcon(Models.Achievement achievement)
        {
            if (achievement.Type == Models.AchievementType.WEB) return "🌐";
            if (achievement.Type == Models.AchievementType.MOBILE) return "📱";
            if (achievement.Type == Models.AchievementType.RICH_CLIENT) return "🖥️";
            return "🤷‍♂️";
        }
    }
}
