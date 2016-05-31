using System.Collections.Generic;
using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface ISkillService : IServiceBase<Skill>
    {
        IEnumerable<Skill> AllByPerson(int personId);
    }
}
