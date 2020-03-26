using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.ViewModels.Common
{
    public class PagedResult<T>
    {
        public List<T> Items { get; set; }
        public int TaltalRecord { get; set; }
    }
}
