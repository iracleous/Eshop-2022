using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Services
{
    public interface IMarketService
    {
        public void AddProductToInventory();
        public void RemoveProductFromInventory();
    }
}
