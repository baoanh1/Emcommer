using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Utilities.Exceptions
{
    public class EcommerceException :Exception
    {
        public EcommerceException()
        {

        }
        public EcommerceException(string message)
        {

        }
        EcommerceException(string message, Exception inner) :base(message, inner)
        {

        }

    }
}
