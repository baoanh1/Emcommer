using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Services;
using Ecommerce.Data.EF;
using Ecommerce.Data.Entities;
using Ecommerce.WebApp.Areas.Admin.ProductModel;
using Ecommerce.WebApp.Areas.Admin.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.WebApp.Areas.Admin.Controllers
{
    //[Authorize]
    [Area("admin")]
    //[Route("admin/[controller]")]

    public class ProductController : Controller
    {
        IUnitOfWork UOW;
        IRepository<Product> _ProductRepository;
        IRepository<ProductCategory> CateRepository;
        
        
        public ProductController(IUnitOfWork uow)
        {
            UOW = uow;
            _ProductRepository = uow.GetRepository<Product>();
            CateRepository = uow.GetRepository<ProductCategory>();
        }
        [Route("admin/product")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("admin/product/list")]
        public ProductListModel Get()
        {
            var productList = ProductListModel.Get(_ProductRepository);
            //var products = _ProductRepository.GetAll().Result;
            //List<ProductViewModel> productViewModel = new List<ProductViewModel>();
            //foreach(var item in products)
            //{
            //    var proview = new ProductViewModel
            //    {
            //        ID = item.ID,
            //        Name = item.Name,
            //        categoryID = item.categoryID,
            //        categoryNames = { },//item.ProductInCategories.Select(x => x.ProductCategory.Name).ToList(),
            //        Price = item.Price,
            //        PromotionPrice = item.PromotionPrice,
            //        Status = item.Status
            //    };
            //    productViewModel.Add(proview);
            //}
            return productList;
        }
        [HttpGet]
        public IActionResult Create()
        {
            //var cateproducts = CateRepository.GetList().Items;
            //ViewBag.cateproducts = cateproducts;

            return View();

        }
        [Route("create")]
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                //var filename = ContentDispositionHeaderValue.Parse(image.ContentDisposition).FileName.Trim('"');
                //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", image.FileName);
                //using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
                //{
                //    await image.CopyToAsync(stream);
                //}
                //product.Image = filename;
                var res = await _ProductRepository.Create(product);
                UOW.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [Route("edit")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //var entiry = Repository.GetByID(1);
            //Repository.Update(entiry);
            //var res = UOW.SaveChanges();
            var product = _ProductRepository.Search(id);

            //var cateproducts = CateRepository.GetList().Items;
            //ViewBag.cateproducts = cateproducts;
            return View();
        }
        [Route("edit")]
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            _ProductRepository.Update(product);
            UOW.SaveChanges();
            return RedirectToAction("Index");
        }


        [Route("delete")]
        public IActionResult Delete(int id)
        {
            _ProductRepository.Delete(id);
            UOW.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}