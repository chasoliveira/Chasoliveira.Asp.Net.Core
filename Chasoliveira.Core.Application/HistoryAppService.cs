using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class HistoryAppService : AppServiceBase<History>, IHistoryAppService
    {
        readonly IHistoryService _historyService;
        public HistoryAppService(IHistoryService historyService) : base(historyService)
        {
            _historyService = historyService;
        }

        public void Add(HistoryDTO item)
        {
            var history = MapperModelDTO.Map<History>(item);
            base.Add(history);
        }

        public new HistoryDTO FindOne(int id)
        {
            var history = base.FindOne(id);
            var historyDto = MapperModelDTO.Map<HistoryDTO>(history);
            return historyDto;
        }

        public HistoryDTO FindOne(Expression<Func<HistoryDTO, bool>> predicate)
        {
            var modelExpression = MapperModelDTO.Map<Expression<Func<History, bool>>>(predicate);
            var histories = base.FindOne(modelExpression);
            var historisDto = MapperModelDTO.Map<HistoryDTO>(histories);
            return historisDto;
        }

        public new IEnumerable<HistoryDTO> All()
        {
            return ToDTO(base.All());
        }

        public IEnumerable<HistoryDTO> All(Expression<Func<HistoryDTO, bool>> predicate)
        {
            return ToDTO(base.All(MapperModelDTO.Map<Expression<Func<History, bool>>>(predicate)));
        }

        public IEnumerable<HistoryDTO> AllEducationByPerson(int personId)
        {
            return ToDTO(_historyService.AllEducationByPerson(personId));
        }

        public IEnumerable<HistoryDTO> AllPositionByPerson(int personId)
        {
            return ToDTO(_historyService.AllPositionByPerson(personId));
        }

        public IEnumerable<HistoryDTO> AllCoursesByPerson(int personId)
        {
            return ToDTO(_historyService.AllCoursesByPerson(personId));
        }

        static IEnumerable<HistoryDTO> ToDTO(IEnumerable<History> histories)
        {
            var historisDto = MapperModelDTO.Map<IEnumerable<HistoryDTO>>(histories);
            return historisDto;
        }
        public void Remove(HistoryDTO item)
        {
            var history = MapperModelDTO.Map<History>(item);
            base.Remove(history);
        }

        public void Update(HistoryDTO item)
        {
            var history = MapperModelDTO.Map<History>(item);
            base.Update(history);
        }

        public new int SaveChanges()
        {
            return base.SaveChanges();
        }

        public void Delete(int id)
        {
            var history = base.FindOne(id);
            base.Remove(history);
        }

    }
}
