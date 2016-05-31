using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Services
{
    public interface ITokenService : IServiceBase<Token>
    {
        Token Generate(int userId, int authTokenExpiry);
        bool Validate(string tokenValue);
        bool Kill(string tokenId);
        bool RemoveByUser(int userId);
    }
}
