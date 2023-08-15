using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCart
{
    internal class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; }

        public Item(string name, double price, int quantity) 
        { 
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public Item() 
        { 
        }
    }
}
