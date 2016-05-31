using System;
using System.Linq;
using System.Linq.Expressions;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Chasoliveira.Core.Data.Repositories
{
    public abstract class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class, new()
    {
        readonly Contexts.ChasoDBContext _context;
        readonly DbSet<T> _dbSet;
        protected RepositoryBase(Contexts.ChasoDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public IQueryable<T> All()
        {
            return _dbSet.AsQueryable();
        }

        public IQueryable<T> All(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public abstract T FindOne(int id);
        public T FindOne(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }
    }
}
