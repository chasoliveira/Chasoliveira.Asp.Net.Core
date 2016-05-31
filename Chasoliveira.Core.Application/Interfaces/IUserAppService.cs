using Chasoliveira.Core.Dto;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface IUserAppService : IAppServiceBase<UserDTO>
    {
        int Authenticate(string username, string password);
    }
}
