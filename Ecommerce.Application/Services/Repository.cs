using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public class Repository<T> : BaseRepository<T>, IRepository<T> where T : class
    {
        public Repository(DbContext context) : base(context)
        {

        }
        public Task<int> Create(T model)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int ProductId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }

        public Task<List<T>> GetAll()
        {
            var items = _dbSet.ToListAsync();
            return items;
        }

        public List<T> GetAllPaging(string keywork, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
