using Chasoliveira.Core.Dto;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface ITokenAppService : IAppServiceBase<TokenDTO>
    {
        bool Validate(string tokenValue);
        TokenDTO Generate(int userId, int v);
    }
}
