using Eshop_2022.EshopDbContext;
using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Services
{
    public class DBMarketService : IMarketService
    {
        private readonly ShopDbContext _context = new ShopDbContext();

        public void AddProductToInventory(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public List<Product> BrowseProducts()
        {
            return _context.Products.ToList();
        }


        public int CreateOrder(int customerId)
        {
            //Customer? customer = _context
            //    .Customers
            //    .Where (customer => customer.Id == customerId).FirstOrDefault();

            Customer? customer2 = _context
              .Customers
              .Find(customerId);

            if (customer2 == null)
                return -1;

            var order = new Order() { Created= DateTime.Now, Customer=customer2   };
            _context.Orders.Add(order);
            return order.Id;    
        }




        public bool AddToOrder(int orderId, int productId)
        {
            Product? product = _context
               .Products
               .Find(productId);

            Order? order = _context
               .Orders
               .Find(orderId);

            if (order!= null && product != null && order.Products!= null)
            {
                order.Products.Add(product);
                _context.SaveChanges();
                return true;
            }
            return false;

        }

      

        public void Checkout(int orderId)
        {
             
        }

   
        public int Login(string userName, string password)
        {
            try
            {
                 return  _context
                                   .Customers
                                   .Where(customer => customer.UserName == userName 
                                                    && customer.Password == password)
                                   .First().Id;

            }
            catch (Exception)
            {
                return -1;
            }
       
        }

        public void Register(string userName, string password)
        {
            int id = Login(userName, password);
            if (id > 0) return;


            _context.Customers.Add( new Customer {
                UserName=userName,
                Password=password,
                RegistrationDate = DateTime.Now
            });
            _context.SaveChanges();
        }

        public void RemoveProductFromInventory(int productId)
        {
            Product? product = _context
             .Products
             .Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
