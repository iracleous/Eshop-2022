﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Models
{
    public class Order:Entity
    {   
        public Customer? Customer { get; set; }
        public List<Product>? Products { get; set; }
    }
}