using Ecommerce.ViewModels.Catalog.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<List<ProductViewModel>> GetAll();
        public PageViewModel<ProductViewModel> GetAllByCategoryId(int productcategoryId, int pageIndex, int pageSize);
    }
}
