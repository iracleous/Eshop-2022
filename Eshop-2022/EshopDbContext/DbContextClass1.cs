using Eshop_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.EshopDbContext
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // string connectionString = "Data Source=(local);Initial Catalog=Eshop-Regen-2022;User Id=sa; Password=passw0rd";
            string connectionString = "Data Source=localhost;Initial Catalog=Eshop-Regen-2022;Integrated Security = true;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}


/*
 * 
add-migration
update-database


 Scaffold-DbContext "Data Source=localhost;Initial Catalog=Eshop-Regen-2022;Integrated Security = true" Microsoft.EntityFrameworkCore.SqlServer -o Model



 *
 */