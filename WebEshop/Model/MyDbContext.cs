using Eshop_2022.Models;
using Microsoft.EntityFrameworkCore;

namespace WebEshop.Model
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Eshop-Regen-2022;Integrated security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
