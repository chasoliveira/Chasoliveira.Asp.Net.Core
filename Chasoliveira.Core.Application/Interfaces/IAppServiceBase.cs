using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Chasoliveira.Core.Application.Interfaces
{
    public interface IAppServiceBase<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        T FindOne(int id);
        T FindOne(Expression<Func<T, bool>> predicate);
        IEnumerable<T> All();
        IEnumerable<T> All(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}
