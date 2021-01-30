using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Providers
{
    public interface IAchievementProvider
    {
        Task<IEnumerable<Achievement>> GetAchievements();
    }
}
