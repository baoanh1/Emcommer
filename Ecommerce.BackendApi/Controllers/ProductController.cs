using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Catalog.Products;
using Ecommerce.Data.Entities;
using Ecommerce.ViewModels.Catalog.Products.Manage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.BackendApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IPublicProductService _productService;
        IManageProductSevice _mangeProductService;
        public ProductController(IManageProductSevice mangeProductService)
        {
            _mangeProductService = mangeProductService;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody]ProductCreateRequest request)
        {
            var productid = await _mangeProductService.Create(request);
            if(productid == 0)
            {
                return BadRequest();
            }
            var product = await _mangeProductService.GetById(productid);
            return CreatedAtAction(nameof(GetById), new { id = productid }, product);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _mangeProductService.GetById(productId);
            if(product==null)
            {
                return BadRequest("Not found product");
            }
            return Ok(product);
        }
        
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }
        public async Task<IActionResult> GetPaging()
        {
            //var products = await _mangeProductService.GetAllPaging();
            return Ok();
        }
    }
}