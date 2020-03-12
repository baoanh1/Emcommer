using Ecommerce.ViewModels.Catalog.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Services
{
    public interface IRepository<T> : IReadRepository<T>, IDisposable where T: class
    {
        Task<int> Create(T model);
        Task<int> Update(T model);
        Task<int> Delete(int ProductId);
        Task<List<T>> GetAll();
        List<T> GetAllPaging(string keywork, int pageIndex, int pageSize);
    }
}
