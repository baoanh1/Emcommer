using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services
{
    public class UnitOfWork<TContext> : IUnitOfWork, IRepositoryFactory, IUnitOfWork<TContext> where TContext:DbContext, IDisposable
    {
        public TContext Context { get; }

        public UnitOfWork(TContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(Context);
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
