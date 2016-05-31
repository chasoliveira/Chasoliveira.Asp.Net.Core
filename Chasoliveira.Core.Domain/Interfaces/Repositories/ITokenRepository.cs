using Chasoliveira.Core.Domain.Entities;

namespace Chasoliveira.Core.Domain.Interfaces.Repositories
{
    public interface ITokenRepository : IRepositoryBase<Token>
    {
        bool Validate(string tokenValue);
    }
}
