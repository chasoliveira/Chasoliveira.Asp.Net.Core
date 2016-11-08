using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class ContactAppService : AppServiceBase<Contact>, IContactAppService
    {
        readonly IContactService _contactService;
        public ContactAppService(IContactService contactService) : base(contactService)
        {
            _contactService = contactService;
        }

        public void Add(ContactDTO item)
        {
            var contact = MapperModelDTO.Map<Contact>(item);
            base.Add(contact);
        }

        public new IEnumerable<ContactDTO> All()
        {
            var contactDto = MapperModelDTO.Map<IEnumerable<ContactDTO>>(base.All());
            return contactDto;
        }

        public IEnumerable<ContactDTO> All(Expression<Func<ContactDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Contact, bool>>>(predicate);
            var contactDto = MapperModelDTO.Map<IEnumerable<ContactDTO>>(base.All(modelExpression));
            return contactDto;
        }

        public IEnumerable<ContactDTO> AllByPerson(int personId)
        {
            var allByPerson = _contactService.AllByPerson(personId);
            var contactsDto = MapperModelDTO.Map<IEnumerable<ContactDTO>>(allByPerson);
            return contactsDto;
        }
        public new ContactDTO FindOne(int id)
        {
            var contact = base.FindOne(id);
            var contactDto = MapperModelDTO.Map<ContactDTO>(contact);
            return contactDto;
        }

        public ContactDTO FindOne(Expression<Func<ContactDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Contact, bool>>>(predicate);
            var contactDto = MapperModelDTO.Map<ContactDTO>(base.FindOne(modelExpression));
            return contactDto;
        }

        public void Remove(ContactDTO item)
        {
            var contact = MapperModelDTO.Map<Contact>(item);
            base.Remove(contact);
        }

        public void Update(ContactDTO item)
        {
            var contact = MapperModelDTO.Map<Contact>(item);
            base.Update(contact);
        }

        public new int SaveChanges() => base.SaveChanges();

        public void Delete(int id)
        {
            var contact = base.FindOne(id);
            base.Remove(contact);
        }

    }
}
