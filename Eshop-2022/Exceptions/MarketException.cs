using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Exceptions
{
    public class MarketException:Exception
    {
  
        public MarketException(string message) : base(message)
        {
        }
    }

    public class MarketExceptions
    {
        public static readonly string DUPLICATE_CUSTOMER  = "Customer allready exists";
        public static readonly string CUSTOMER_NOT_FOUND = "Customer not found";
        public static readonly string CUSTOMER_INVALID_DATA = "Invalid data";
        public static readonly string CUSTOMER_NOT_PERMITTED_USERNAME = "This username is not permitted";
    }
}
