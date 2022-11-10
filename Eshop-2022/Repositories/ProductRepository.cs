using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products
             = new List<Product>();

        public int CreateProduct(Product product)
        {
            Console.WriteLine("The product has been added");
            _products.Add(product);
            return 0;
        }

        public Product CreateProduct(int productId, string name, decimal price, DateTime purchaseDate)
        {
            return null;
        }

        public bool DeleteProduct(int productId)
        {/* to do -> possible run time error */
            _products.Remove(ReadProductId(productId));
            return true;
        }

        public Product ReadProductId(int productId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(int productId, decimal newPrice)
        {
            throw new NotImplementedException();
        }
    }
}
