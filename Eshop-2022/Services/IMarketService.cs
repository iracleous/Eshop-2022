using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Services
{
    public interface IMarketService
    {
        //member of the staff
        public void AddProductToInventory(Product product);
        public void RemoveProductFromInventory(int productId);

        //user actions
        public bool Register(string userName, string password);
        public List<Product> BrowseProducts();
     //   public List<Product> BrowseProducts(string productName);
        public int Login(string userName, string password);
        public int CreateOrder(int customerId);
        public void AddToOrder(int orderId, int productId, int quantity);
        public void Checkout(int orderId);
    }
}
