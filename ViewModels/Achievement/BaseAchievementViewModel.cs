namespace Portfolio.ViewModels.Achievement
{
    public class BaseRealisationViewModel : BaseDetailViewModel
    {
        public string GetAchievementTypeIcon(Models.Achievement achievement)
        {
            return achievement.Type switch
            {
                Models.AchievementType.Web => "🌐",
                Models.AchievementType.Mobile => "📱",
                Models.AchievementType.RichClient => "🖥️",
                _ => "🤷‍♂️"
            };
        }
    }
}
