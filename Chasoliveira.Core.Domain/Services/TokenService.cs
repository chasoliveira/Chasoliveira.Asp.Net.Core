using System;
using Chasoliveira.Core.Common.Extensions;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class TokenService : ServiceBase<Token>, ITokenService
    {
        readonly ITokenRepository _tokenRepository;
        public TokenService(ITokenRepository tokenRepository) : base(tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }

        public Token Generate(int userId, int authTokenExpiry)
        {
            var token = Guid.NewGuid().ToString();
            var issuedOn = DateTime.Now;
            var expiredOn = DateTime.Now.AddSeconds(authTokenExpiry);
            var tokendomain = new Token
            {
                UserId = userId,
                AuthToken = token,
                IssuedOn = issuedOn,
                ExpiresOn = expiredOn,
                LastSync = issuedOn
            };

            base.Add(tokendomain);
            SaveChanges();

            return tokendomain;
        }
        public bool Kill(string tokenId)
        {
            var token = FindOne(t => t.AuthToken.Equals(tokenId));
            Remove(token);
            return true;
        }
        public bool RemoveByUser(int userId)
        {
            var tokens = All(t => t.UserId == userId);
            tokens.ForEach(Remove);
            return true;
        }
        public bool Validate(string tokenValue)
        {
            return _tokenRepository.Validate(tokenValue);
        }
    }
}
