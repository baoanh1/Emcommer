using Ecommerce.Application.Services;
using Ecommerce.Data.Entities;
using Ecommerce.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.WebApp.Areas.Admin.ProductModel
{
    public class ProductListModel
    {
        public IList<ListItem> Products { get; set; }
        public static ProductListModel Get(IRepository<Product> ProductRepository)
        {
           
            
            var products = ProductRepository.GetAll().Result;
            var get = products.Where(p => p.ID == 1)
            .Select(pro => new
            {
                ID = pro.ID,
                Name = pro.Name,
                AttendedCountryClubs = pro.ProductInCategories.Where(cat=>cat.ProductID==1),
            });
            var model = new ProductListModel
            {
                Products = products.OrderBy(p => p.Name).Select(p => new ListItem
                {
                    ID = p.ID,
                    Name = p.Name,
                    categoryNames = p.ProductInCategories.Select(x => x.ProductCategory.Name).ToList(),
                }).ToList()
            };
            
            return model;
        }
        public class ListItem
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
            public string MetaTitle { get; set; }
            public string Description { get; set; }

            public decimal Price { get; set; }

            public decimal PromotionPrice { get; set; }

            public int Quantity { get; set; }

            public long categoryID { get; set; }
            public IList<string> categoryNames { get; set; } = new List<string>();
            public string Detail { get; set; }

            public int Warranty { get; set; }

            public string MetaKeywords { get; set; }

            public string MetaDescriptions { get; set; }

            public Status Status { get; set; }

            public bool TopHot { get; set; }

            public int ViewCount { get; set; }
        }

    }
}
