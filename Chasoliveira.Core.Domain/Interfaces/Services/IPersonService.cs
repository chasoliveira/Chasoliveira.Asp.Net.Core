using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface IPersonService: IServiceBase<Person>
    {
        Person FirstActive();
    }
}
