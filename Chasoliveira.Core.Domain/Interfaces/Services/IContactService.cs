using System.Collections.Generic;
using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface IContactService: IServiceBase<Contact>
    {
        IEnumerable<Contact> AllByPerson(int personId);
    }
}
