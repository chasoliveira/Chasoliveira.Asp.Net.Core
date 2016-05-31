using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class SkillRepository : RepositoryBase<Skill>, ISkillRepository
    {
        public SkillRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }

        public override Skill FindOne(int id)
        {
            return FindOne(s => s.Id == id);
        }
    }
}
