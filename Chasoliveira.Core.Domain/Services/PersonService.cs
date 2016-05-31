using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {
        }
    }
}
