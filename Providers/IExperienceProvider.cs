using System.Collections.Generic;
using System.Threading.Tasks;
using Portfolio.Models;

namespace Portfolio.Providers.Implementations
{
    public interface IExperienceProvider
    {
        Task<IEnumerable<Experience>> GetExperiences();
    }
}