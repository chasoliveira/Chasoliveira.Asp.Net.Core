using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class SocialRepository : RepositoryBase<Social>, ISocialRepository
    {
        public SocialRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }

        public override Social FindOne(int id)
        {
            return FindOne(s => s.Id == id);
        }
    }
}
