namespace Portfolio.ViewModels.Achievement
{
    public class BaseRealisationViewModel : BaseDetailViewModel
    {
        public string GetAchievementTypeIcon(Models.Achievement achievement)
        {
            return achievement.Type switch
            {
                Models.AchievementType.Web => "Application web",
                Models.AchievementType.Mobile => "Application mobile",
                Models.AchievementType.RichClient => "🖥️",
                _ => "🤷‍♂️"
            };
        }
    }
}
