using Ecommerce.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> ProductCategoryIds { get; set; }
    }
}
