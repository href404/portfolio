using System.Collections.Generic;

namespace Portfolio.ViewModels.Achievement
{
    public class AchievementDetailViewModel : BaseRealisationViewModel
    {
        public Models.Achievement Achievement { get; init; }
        public IEnumerable<Models.Skill> Skills { get; init; }
    }
}
