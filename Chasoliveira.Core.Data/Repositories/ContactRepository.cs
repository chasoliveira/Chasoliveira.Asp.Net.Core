using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }     

        public override Contact FindOne(int id)
        {
            return FindOne(c => c.Id == id);
        }
    }
}
