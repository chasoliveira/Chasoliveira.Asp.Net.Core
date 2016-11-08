using System;
using System.Collections.Generic;
using System.Linq;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class ContactService : ServiceBase<Contact>, IContactService
    {
        readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository) : base(contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IEnumerable<Contact> AllByPerson(int personId)
        {
            return _contactRepository.All(c => c.PersonId == personId).OrderBy(c => c.Ord).ToList();
        }
    }
}
