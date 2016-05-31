using System.Collections.Generic;
using Chasoliveira.Core.Dto;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface IContactAppService : IAppServiceBase<ContactDTO>
    {
        void Delete(int id);
        IEnumerable<ContactDTO> AllByPerson(int personId);
    }
}
