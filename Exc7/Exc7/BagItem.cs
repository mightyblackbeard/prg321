using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc7
{
    public class BagItem
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        public double subTotal { get; set; }

        public BagItem(string name, int quantity, double price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
            this.subTotal = price * quantity;

        }
    }
}
