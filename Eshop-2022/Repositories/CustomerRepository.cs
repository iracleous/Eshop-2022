using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        public override bool Update(int id, Customer otherT)
        {
            throw new NotImplementedException();
        }
        public bool ExistsUsername(string username)
        {
            foreach(var customer in Read())
            {
                if (customer.UserName == username)
                    return true;
            }
            return false;
        }
    }
}
