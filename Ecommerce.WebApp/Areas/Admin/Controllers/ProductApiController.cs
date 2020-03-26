using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Catalog.Products;
using Ecommerce.ViewModels.Catalog.Products.Manage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("[controller]/[action]")]
    public class ProductApiController : Controller
    {
        IManageProductSevice _mangeProductService;
        public ProductApiController(IManageProductSevice mangeProductService)
        {
            _mangeProductService = mangeProductService;
        }
        [HttpGet]
        public IActionResult Create()
        {
            var product = new ProductCreateRequest();
            return View(product);
        }
        [HttpPost]
        
        public IActionResult Create(ProductCreateRequest request, IFormFile image)
        {
            request.ThumbnailImage = image;
            _mangeProductService.Create(request);
            return View();
        }
    }
}