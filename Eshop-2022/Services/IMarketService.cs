using Eshop_2022.Models;

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
        public bool AddToOrder(int orderId, int productId );
        public void Checkout(int orderId);
    }
}
