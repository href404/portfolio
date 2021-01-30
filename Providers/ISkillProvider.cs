using Portfolio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portfolio.Providers
{
    public interface ISkillProvider
    {
        Task<IEnumerable<Skill>> GetSkills();
    }
}
