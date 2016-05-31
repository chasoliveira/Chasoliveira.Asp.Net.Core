using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;

namespace Chasoliveira.Core.Data.Repositories
{
    public class HistoryRepository : RepositoryBase<History>, IHistoryRepository
    {
        public HistoryRepository(Contexts.ChasoDBContext context) : base(context)
        {
        }

        public override History FindOne(int id)
        {
            return FindOne(h => h.Id == id);
        }
    }
}