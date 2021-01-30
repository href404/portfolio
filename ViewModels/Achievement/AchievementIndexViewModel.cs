using System.Collections.Generic;

namespace Portfolio.ViewModels.Achievement
{
    public class AchievementIndexViewModel : BaseRealisationViewModel
    {
        public IEnumerable<Models.Achievement> Achievements { get; set; }
    }
}
