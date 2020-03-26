using Ecommerce.Application.Common;
using Ecommerce.Data.EF;
using Ecommerce.Data.Entities;
using Ecommerce.Utilities.Exceptions;
using Ecommerce.ViewModels.Catalog.Product;
using Ecommerce.ViewModels.Catalog.Products.Manage;
using Ecommerce.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Catalog.Products
{
    public class ManageProductService : IManageProductSevice
    {
        protected EcommerceDbContext _context;
        private IStorageService _storageService;
        public ManageProductService(EcommerceDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
    }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var status = 0;
            var product = new Product { 
                Name = request.Name,
                Price = request.Price,
                PromotionPrice = request.PromotionPrice,
                Description = request.Description,
                Detail = request.Detail
            };
            if(request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage
                    {
                        Caption = "thumbnail image",
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage)
                    }
                };

            }
            var res = _context.Products.Add(product);
            if(res!=null)
            {
                status = await _context.SaveChangesAsync();
            }
            return product.ID;

        }
        
       
        public async Task<int> Delete(int ProductId)
        {
            var product = await _context.Products.FindAsync(ProductId);
            if (product == null) throw new EcommerceException($"Not found product:{ProductId}");
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public Task<ProductViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            var query = from p in _context.Products
                        join pic in _context.ProductIncategories on p.ID equals pic.ProductID
                        join c in _context.ProductCategories on pic.ProductCategoryID equals c.ID
                        select new { p, pic };
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x => x.p.Name.Contains(request.Keyword));
            if(request.ProductCategoryIds.Count > 0)
            {
                query = query.Where(p => request.ProductCategoryIds.Contains(p.pic.ProductCategoryID));
            }
            int totalRow = query.Count();
            var data = query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new ProductViewModel
            {
                ID = x.p.ID,
                Name = x.p.Name,
            }).ToList();
            var pageresult = new PagedResult<ProductViewModel>()
            { 
                TaltalRecord = totalRow,
                Items = data
            };
            return pageresult;
        }

        public Task<ProductViewModel> GetById(int ProductId)
        {
            var product = _context.Products.Find(ProductId);
            var productview = new ProductViewModel()
            {
                ID = product.ID,
                Name = product.Name
            };
            return Task.FromResult(productview);
      

        }

        public Task<int> Update(ProductUpdateRequest request)
        {
            throw new NotImplementedException();
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}
