using Ecommerce.Data.EF;
using Ecommerce.ViewModels.Catalog.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Ecommerce.Application.Common;

namespace Ecommerce.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        protected EcommerceDbContext _context;
        protected IStorageService _storageService;
        public PublicProductService(EcommerceDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }
        public async Task<List<ProductViewModel>> GetAll()
        {
            var query = from p in _context.Products
                        join pic in _context.ProductIncategories on p.ID equals pic.ProductID
                        join c in _context.ProductCategories on pic.ProductCategoryID equals c.ID
                        select new { p, pic };
            var data = query.Select(x => new ProductViewModel
            {
                ID = x.p.ID,
                Name = x.p.Name
            });
            
            return data.ToList();
        }

        public PageViewModel<ProductViewModel> GetAllByCategoryId(int productcategoryId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
