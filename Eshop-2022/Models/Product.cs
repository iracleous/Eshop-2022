using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Models
{
    public class Product:Entity
    {
        public string? Name { get; set; }
        public DateTime PurchaseDate  { get; set; }
        public decimal Price { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
