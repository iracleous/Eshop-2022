using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public interface IProductRepository
    {
        //CRUD create read update delete

        public int CreateProduct(Product product);
        public Product CreateProduct(int productId, string name,
            decimal price, DateTime purchaseDate);
        public Product? ReadProductId(int productId);
        public bool UpdateProduct(int productId, decimal newPrice);
        public bool DeleteProduct(int productId);   

    }
}
