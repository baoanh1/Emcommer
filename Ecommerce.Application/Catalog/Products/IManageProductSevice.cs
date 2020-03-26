using Ecommerce.ViewModels.Catalog.Product;
using Ecommerce.ViewModels.Catalog.Products.Manage;
using Ecommerce.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Products
{
    public interface IManageProductSevice
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<ProductViewModel> GetById(int ProductId);
        Task<int> Delete(int ProductId);
        Task<ProductViewModel> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
