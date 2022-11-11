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
        private readonly List<Product> _products = new ();
        private int ProductIndex = 0;


        public int CreateProduct(Product product)
        {
            product.Id = ProductIndex;
            ProductIndex++;
            _products.Add(product);
            return product.Id;
        }

        public Product CreateProduct(int productId, string name, decimal price, DateTime purchaseDate)
        {
           var product = new Product() { Id = productId, Name = name, Price = price,
               PurchaseDate = purchaseDate };
            CreateProduct(product);
            return product;
        }

        public bool DeleteProduct(int productId)
        {  
            Product? product= ReadProductId(productId);
            if (product != null) {  
                _products.Remove(product);
                return true;
            }
           return false;
        }

        public Product? ReadProductId(int productId)
        {
            foreach(Product product in _products)
            {
                if (product.Id == productId)
                    return product;
            }
            return null;
        }

        public bool UpdateProduct(int productId, decimal newPrice)
        {
            Product? product = ReadProductId(productId);
            if (product != null)
            {
                product.Price = newPrice;
                return true;
            }
            return false;    
        }
    }
}
