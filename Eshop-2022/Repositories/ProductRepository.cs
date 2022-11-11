using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public override bool Update(int id, Product otherT)
        {
            Product? product = Read(id);
            if (product != null)
            {
                product.Price = otherT.Price;
                return true;
            }
            return false;
        }
    }
}
