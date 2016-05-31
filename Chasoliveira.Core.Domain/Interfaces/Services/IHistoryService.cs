using System.Collections.Generic;
using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface IHistoryService : IServiceBase<History>
    {
        IEnumerable<History> AllPositionByPerson(int personId);
        IEnumerable<History> AllCoursesByPerson(int personId);
        IEnumerable<History> AllEducationByPerson(int personId);
    }
}
