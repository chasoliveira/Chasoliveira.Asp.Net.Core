using System.Collections.Generic;
using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface ISocialService : IServiceBase<Social>
    {
        IEnumerable<Social> AllByPerson(int personId);
    }
}
