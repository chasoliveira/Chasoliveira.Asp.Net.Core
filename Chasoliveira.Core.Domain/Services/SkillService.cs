using System;
using System.Collections.Generic;
using System.Linq;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class SkillService : ServiceBase<Skill>, ISkillService
    {
        readonly ISkillRepository _skillRepository;
        public SkillService(ISkillRepository skillRepository) : base(skillRepository)
        {
            _skillRepository = skillRepository;
        }

        public IEnumerable<Skill> AllByPerson(int personId)
        {
            return _skillRepository.All(c => c.PersonId == personId).OrderBy(c => c.Ord);
        }
    }
}
