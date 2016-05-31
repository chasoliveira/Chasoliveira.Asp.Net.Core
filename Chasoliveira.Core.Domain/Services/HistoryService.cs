using System;
using System.Collections.Generic;
using System.Linq;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class HistoryService : ServiceBase<History>, IHistoryService
    {
        readonly IHistoryRepository _historyRepository;
        public HistoryService(IHistoryRepository historyRepository) : base(historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public IEnumerable<History> AllCoursesByPerson(int personId)
        {
            return _historyRepository.All(h => h.PersonId == personId && h.HistoryType == HistoryType.Courses).OrderBy(c => c.Ord);
        }

        public IEnumerable<History> AllEducationByPerson(int personId)
        {
            return _historyRepository.All(h => h.PersonId == personId && h.HistoryType == HistoryType.Education).OrderBy(c => c.Ord);
        }

        public IEnumerable<History> AllPositionByPerson(int personId)
        {
            return _historyRepository.All(h => h.PersonId == personId && h.HistoryType == HistoryType.Position).OrderBy(c => c.Ord);
        }
    }
}
