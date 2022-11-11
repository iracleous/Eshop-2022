using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public class OrderRepository : Repository<Order>
    {
        public override bool Update(int id, Order otherT)
        {
            throw new NotImplementedException();
        }
    }
}
