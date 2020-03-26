using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.ViewModels.Catalog.Products.Manage
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal PromotionPrice { get; set; }

        public int Quantity { get; set; }

        public long categoryID { get; set; }

        public string Detail { get; set; }
        public IFormFile ThumbnailImage { get; set; }
    }
}
