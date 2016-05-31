using System.Collections.Generic;
using Chasoliveira.Core.Dto;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface ISocialAppService : IAppServiceBase<SocialDTO>
    {
        void Delete(int id);
        IEnumerable<SocialDTO> AllByPerson(int personId);
    }
}
