using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusC_Unit4
{
    internal class Order
    {
        public List<Product> Cart { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }


    }
}
