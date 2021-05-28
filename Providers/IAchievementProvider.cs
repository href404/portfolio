using Portfolio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Providers
{
    public interface IAchievementProvider
    {
        Task<IEnumerable<Achievement>> GetAchievements();
    }
}
