using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class PersonAppService : AppServiceBase<Person>, IPersonAppService
    {
        public PersonAppService(IPersonService personService) : base(personService)
        {
        }

        PersonDTO IAppServiceBase<PersonDTO>.FindOne(Expression<Func<PersonDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Person, bool>>>(predicate);
            var item = base.FindOne(modelExpression);
            var person = MapperModelDTO.Map<PersonDTO>(item);
            return person;
        }

        public void Add(PersonDTO item)
        {
            var person = MapperModelDTO.Map<Person>(item);
            base.Add(person);
        }

        public new IEnumerable<PersonDTO> All()
        {
            var personDto = MapperModelDTO.Map<IEnumerable<PersonDTO>>(base.All());
            return personDto;
        }
        public IEnumerable<PersonDTO> All(Expression<Func<PersonDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Person, bool>>>(predicate);
            var personDto = MapperModelDTO.Map<IEnumerable<PersonDTO>>(base.All(modelExpression));
            return personDto;
        }

        public void Remove(PersonDTO item)
        {
            var person = MapperModelDTO.Map<Person>(item);
            base.Remove(person);
        }

        public void Update(PersonDTO item)
        {
            var person = MapperModelDTO.Map<Person>(item);
            base.Update(person);
        }

        public new PersonDTO FindOne(int id)
        {
            var person = base.FindOne(id);
            var personDto = MapperModelDTO.Map<PersonDTO>(person);
            return personDto;
        }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
