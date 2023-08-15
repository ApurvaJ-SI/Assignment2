using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCart
{
    internal class ShoppingCart
    {
        List<Item> items;

        public ShoppingCart()
        {
            items = new List<Item>();
        }

        public void AddItems(Item item)
        {
            items.Add(item);
        }

        public void DisplayListOfItem()
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"Item:{item.Name}, Price:{item.Price}, Quantity:{item.Quantity}");
            }
        }

        public void CalculateAmount()
        {
            foreach (Item item in items)
            {
                double amount = item.Quantity * item.Price;
                Console.WriteLine(amount);
            }
        }
    }
}
