using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Models
{
    public class Customer:Entity
    {
        public string UserName { get; set; } = "";
        public string Password { get; set; } ="";
        public DateTime RegistrationDate { get; set; }
    }
}
