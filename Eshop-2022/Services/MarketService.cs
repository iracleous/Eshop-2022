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

        public int Login(string userName, string password)
        {
            return customerRepository.Read(userName,  password);
        }

        public int CreateOrder(int customerId)
        {
            Customer? customer = customerRepository.Read(customerId);
            if (customer == null)
            {
                return -1;
            }
            var order = new Order()
            {
                Customer = customer,
                Products = new List<Product>(),
                Created = DateTime.Now
            };
            orderRepository.Create(order);
            return order.Id;
        }

        public bool AddToOrder(int orderId, int productId )
        {
            Order? order = orderRepository.Read(orderId);
            Product? product = productRepository.Read(productId);
            if( order!= null && product != null)
            {
                order.Products.Add(product);
                return true;
            }
            return false;
        }

          public void Checkout(int orderId)
        {

            Order? order = orderRepository.Read(orderId);
            if (order != null)
            {
                decimal totalCost = 0m;
                int productCount = 0;
                foreach(Product product in order.Products){
                    productCount++;
                    totalCost += product.Price;
                }
                System.Console.WriteLine($"total cost = {totalCost} " +
                    $"product count = {productCount}");
            }
            Console.WriteLine("The customer has checked out");
        }

       

       

      

        
    }
}
