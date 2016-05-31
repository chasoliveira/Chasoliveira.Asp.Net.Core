using System;
using System.Linq;
using System.Linq.Expressions;

namespace Chasoliveira.Core.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class, new()
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        T FindOne(int id);
        T FindOne(Expression<Func<T, bool>> predicate);
        IQueryable<T> All();
        IQueryable<T> All(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}