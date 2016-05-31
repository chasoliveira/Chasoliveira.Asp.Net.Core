using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class, new()
    {
        readonly IRepositoryBase<T> _repositoryBase;
        public ServiceBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Add(T item) => _repositoryBase.Add(item);
        public IEnumerable<T> All() => _repositoryBase.All().ToList();
        public IEnumerable<T> All(Expression<Func<T, bool>> predicate) => _repositoryBase.All(predicate).ToList();
        public virtual T FindOne(int id) => _repositoryBase.FindOne(id);
        public T FindOne(Expression<Func<T, bool>> predicate) => _repositoryBase.FindOne(predicate);
        public void Remove(T item) => _repositoryBase.Remove(item);
        public void Update(T item) => _repositoryBase.Update(item);
        public int SaveChanges() => _repositoryBase.SaveChanges();
    }
}
