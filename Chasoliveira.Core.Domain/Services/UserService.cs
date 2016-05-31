using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public int Authenticate(string username, string password)
        {
            var user = _userRepository.FindOne(u => u.UserName == username && u.Password == password);
            if (user != null && user.Id > 0)
            {
                return user.Id;
            }
            return 0;
        }
    }
}
