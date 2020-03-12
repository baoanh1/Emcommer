using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services
{
    public interface IReadRepository<T> where T : class
    {
        IEnumerable<T> Query(string sql, params object[] parameters);
        T Search(params object[] keyValues);
    }
}
