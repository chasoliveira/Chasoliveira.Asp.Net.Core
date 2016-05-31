using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }

        public override User FindOne(int id)
        {
            return FindOne(u => u.Id == id);
        }
    }
}
