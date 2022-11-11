// See https://aka.ms/new-console-template for more information
using Eshop_2022.Models;
using Eshop_2022.Repositories;
using Eshop_2022.Services;

Console.WriteLine("My eshop application starts");

 

IMarketService service = new MarketService();

service.AddProductToInventory(new Product()
    {
        Name = "Snack",
        Price = 1.30m,
        PurchaseDate = DateTime.Now
    });

service.AddProductToInventory(new Product()
{
    Name = "Chocolate",
    Price = 2.30m,
    PurchaseDate = DateTime.Now
});

service.Register("Dimitris", "1234");

int loginId = service.Login("Dimitris", "1234");

List<Product> products = service.BrowseProducts();

int orderId = service.CreateOrder(loginId);

service.AddToOrder(orderId, 1);
service.AddToOrder(orderId, 0);
service.AddToOrder(orderId, 2);

service.Checkout(orderId);





