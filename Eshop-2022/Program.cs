// See https://aka.ms/new-console-template for more information
using Eshop_2022.Models;
using Eshop_2022.Repositories;

Console.WriteLine("My eshop application starts");

var product = new Product() { Id = 12, Name = "Snack", Price = 1.30m, 
    PurchaseDate = DateTime.Now};

IRepository<Product> productRepository = new ProductRepository();
int productId = productRepository.Create(product);

Console.WriteLine(productId);
