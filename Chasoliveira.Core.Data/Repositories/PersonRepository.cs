using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }

        public override Person FindOne(int id)
        {
            return FindOne(p => p.Id == id);
        }
    }
}
