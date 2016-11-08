using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Application
{
    public abstract class AppServiceBase<T> where T : class, new()
    {
        protected readonly IServiceBase<T> _serviceBase;
        protected AppServiceBase(IServiceBase<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        protected void Add(T item) => _serviceBase.Add(item);
        protected IEnumerable<T> All() => _serviceBase.All();
        protected IEnumerable<T> All(Expression<Func<T, bool>> predicate) => _serviceBase.All(predicate);
        protected T FindOne(int id) => _serviceBase.FindOne(id);
        protected T FindOne(Expression<Func<T, bool>> predicate) => _serviceBase.FindOne(predicate);
        protected void Remove(T item) => _serviceBase.Remove(item);
        protected int SaveChanges() => _serviceBase.SaveChanges();
        protected void Update(T item) => _serviceBase.Update(item);
    }
}
