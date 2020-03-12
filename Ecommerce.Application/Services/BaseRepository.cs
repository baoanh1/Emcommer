using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services
{
    public abstract class BaseRepository<T> : IReadRepository<T> where T : class
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(DbContext context)
        {
            _dbContext = context??throw new ArgumentException(nameof(context));
            _dbSet = _dbContext.Set<T>();
        }   

        public IEnumerable<T> Query(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public T Search(params object[] keyValues)
        {
            throw new NotImplementedException();
        }
    }
}
