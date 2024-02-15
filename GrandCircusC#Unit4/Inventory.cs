using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusC_Unit4
{
    internal class Inventory
    {
        public List<Product> InventoryList { get; set; } = new List<Product>();

        public Inventory()
        {
            InventoryList = new List<Product>();
        }
    }
}
