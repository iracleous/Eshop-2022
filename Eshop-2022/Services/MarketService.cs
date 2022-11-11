using Eshop_2022.Models;
using Eshop_2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Services
{
    public class MarketService : IMarketService
    {
        private readonly ProductRepository productRepository = new ProductRepository();
        private readonly CustomerRepository customerRepository = new CustomerRepository();
        private readonly OrderRepository orderRepository = new OrderRepository();

        public void AddProductToInventory(Product product)
        {
            productRepository.Create(product);
        }

        public void RemoveProductFromInventory(int productId)
        {
           productRepository.Delete(productId);
        }

 public List<Product> BrowseProducts()
        {
            return productRepository.Read();
        }

        public bool Register(string userName, string password)
        {
            if (customerRepository.ExistsUsername(userName))
            {
                return false;
            }
            Customer customer = new() { UserName=userName, 
                Password=password, RegistrationDate = DateTime.Now};
            customerRepository.Create(customer);
            return true;
        }


        public void AddToOrder(int orderId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

       

        public void Checkout(int orderId)
        {
            throw new NotImplementedException();
        }

        public int CreateOrder(int customerId)
        {
            throw new NotImplementedException();
        }

        public int Login(string userName, string password)
        {
            throw new NotImplementedException();
        }

      

        
    }
}
