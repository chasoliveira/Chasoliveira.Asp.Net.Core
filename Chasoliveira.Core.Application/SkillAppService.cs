using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class SkillAppService : AppServiceBase<Skill>, ISkillAppService
    {
        readonly ISkillService _skillService;
        public SkillAppService(ISkillService skillService) : base(skillService)
        {
            _skillService = skillService;
        }

        public void Add(SkillDTO item)
        {
            var skill = MapperModelDTO.Map<Skill>(item);
            base.Add(skill);
        }

        public new IEnumerable<SkillDTO> All()
        {
            var skills = base.All();
            var skillsDto = MapperModelDTO.Map<IEnumerable<SkillDTO>>(skills);
            return skillsDto;
        }

        public new SkillDTO FindOne(int id)
        {
            var skill = base.FindOne(id);
            var skillDto = MapperModelDTO.Map<SkillDTO>(skill);
            return skillDto;
        }
        public SkillDTO FindOne(Expression<Func<SkillDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Skill, bool>>>(predicate);
            var skills = base.FindOne(modelExpression);
            var skillsDto = MapperModelDTO.Map<SkillDTO>(skills);
            return skillsDto;
        }
        public IEnumerable<SkillDTO> All(Expression<Func<SkillDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<Skill, bool>>>(predicate);
            var skills = base.All(modelExpression);
            var skillsDto = MapperModelDTO.Map<IEnumerable<SkillDTO>>(skills);
            return skillsDto;
        }

        public void Remove(SkillDTO item)
        {
            var skill = MapperModelDTO.Map<Skill>(item);
            base.Remove(skill);
        }

        public void Update(SkillDTO item)
        {
            var skill = MapperModelDTO.Map<Skill>(item);
            base.Update(skill);
        }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

        public void Delete(int id)
        {
            var skill = base.FindOne(id);
            base.Remove(skill);
        }

        public IEnumerable<SkillDTO> AllByPerson(int personId)
        {
            var skills = _skillService.AllByPerson(personId);
            var skillsDto = MapperModelDTO.Map<IEnumerable<SkillDTO>>(skills);
            return skillsDto;
        }
    }
}
