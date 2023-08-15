using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Product
    {

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string Category { get; set; }

        public Product()
        {
        }
        public Product(string name, double price, int quantity, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;
        }

       
        
        public override string ToString()
        {
            return $"Name = {Name} Price = {Price} Quantity = {Quantity} Category = {Category}";
        }
    }
}
