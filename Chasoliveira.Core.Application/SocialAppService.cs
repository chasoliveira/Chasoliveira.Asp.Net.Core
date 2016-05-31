using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class SocialAppService : AppServiceBase<Social>, ISocialAppService
    {
        readonly ISocialService _socialService;
        public SocialAppService(ISocialService socialService) : base(socialService)
        {
            _socialService = socialService;
        }

        public void Add(SocialDTO item)
        {
            var social = MapperModelDTO.Map<Social>(item);
            base.Add(social);
        }

        public new IEnumerable<SocialDTO> All()
        {
            return ToDto(base.All());
        }

        public IEnumerable<SocialDTO> All(Expression<Func<SocialDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Social, bool>>>(predicate);            
            return ToDto(base.All(modelExpression));
        }
        public IEnumerable<SocialDTO> AllByPerson(int personId)
        {
            return ToDto(_socialService.AllByPerson(personId));
        }

        static IEnumerable<SocialDTO> ToDto(IEnumerable<Social> socials)
        {
            return MapperModelDTO.Map<IEnumerable<SocialDTO>>(socials);
        }
        public new SocialDTO FindOne(int id)
        {
            var social = base.FindOne(id);
            return MapperModelDTO.Map<SocialDTO>(social);
        }

        public SocialDTO FindOne(Expression<Func<SocialDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Social, bool>>>(predicate);
            var socials = base.FindOne(modelExpression);
            return MapperModelDTO.Map<SocialDTO>(socials);
        }

        public void Remove(SocialDTO item)
        {
            var social = MapperModelDTO.Map<Social>(item);
            base.Remove(social);
        }

        public void Update(SocialDTO item)
        {
            var social = MapperModelDTO.Map<Social>(item);
            base.Update(social);
        }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

        public void Delete(int id)
        {
            var social = base.FindOne(id);
            base.Remove(social);
        }

    }
}
