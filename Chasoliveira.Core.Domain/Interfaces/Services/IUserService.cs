using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        int Authenticate(string username, string password);
    }
}
