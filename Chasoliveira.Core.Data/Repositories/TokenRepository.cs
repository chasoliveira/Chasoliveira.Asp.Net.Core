using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class TokenRepository : RepositoryBase<Token>, ITokenRepository
    {
        public TokenRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }

        public override Token FindOne(int id)
        {
            return FindOne(t => t.Id == id);
        }

        public bool Validate(string tokenValue)
        {
            var token = FindOne(t => t.AuthToken.Equals(tokenValue));
            return token?.IsValid ?? false;
        }
    }
}
