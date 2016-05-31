using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Application.Interfaces;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public class TokenAppService : AppServiceBase<Token>, ITokenAppService
    {
        readonly ITokenService _tokenService;
        public TokenAppService(ITokenService tokenService) : base(tokenService)
        {
            _tokenService = tokenService;
        }

        public void Add(TokenDTO item)
        {
            var token = MapperModelDTO.Map<Token>(item);
            base.Add(token);
        }
        public new IEnumerable<TokenDTO> All()
        {
            var tokens = base.All();
            var tokensDto = MapperModelDTO.Map<IEnumerable<TokenDTO>>(tokens);
            return tokensDto;
        }

        public new TokenDTO FindOne(int id)
        {
            var token =base.FindOne(id);
            var tokenDto = MapperModelDTO.Map<TokenDTO>(token);
            return tokenDto;
        }

        public TokenDTO FindOne(Expression<Func<TokenDTO, bool>> predicate)
        {
            var tokenExpression = MapperModelDTO.Map<Expression<Func<Token, bool>>>(predicate);
            var token = base.FindOne(tokenExpression);
            var tokenDto = MapperModelDTO.Map<TokenDTO>(token);
            return tokenDto;
        }
        public IEnumerable<TokenDTO> All(Expression<Func<TokenDTO, bool>> predicate)
        {
            var tokenExpression = MapperModelDTO.Map<Expression<Func<Token, bool>>>(predicate);
            var tokens = base.All(tokenExpression);
            var tokensDto = MapperModelDTO.Map<IEnumerable<TokenDTO>>(tokens);
            return tokensDto;
        }


        public void Remove(TokenDTO item)
        {
            var token = MapperModelDTO.Map<Token>(item);
            base.Remove(token);
        }

        public void Update(TokenDTO item)
        {
            var token = MapperModelDTO.Map<Token>(item);
            base.Update(token); 
        }

        public bool Validate(string tokenValue) => _tokenService.Validate(tokenValue);

        public new int SaveChanges() => base.SaveChanges();

        public TokenDTO Generate(int userId, int authTokenExpiry)
        {
            var token = _tokenService.Generate(userId, authTokenExpiry);
            return MapperModelDTO.Map<TokenDTO>(token);
        }
    }
}
