using System.Collections.Generic;
using Chasoliveira.Core.Dto;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface IHistoryAppService : IAppServiceBase<HistoryDTO>
    {
        void Delete(int id);
        IEnumerable<HistoryDTO> AllEducationByPerson(int personId);
        IEnumerable<HistoryDTO> AllPositionByPerson(int personId);
        IEnumerable<HistoryDTO> AllCoursesByPerson(int personId);
    }
}
