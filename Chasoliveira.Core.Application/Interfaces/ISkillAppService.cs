using System.Collections.Generic;
using Chasoliveira.Core.Dto;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface ISkillAppService : IAppServiceBase<SkillDTO>
    {
        void Delete(int id);
        IEnumerable<SkillDTO> AllByPerson(int personId);
    }
}
