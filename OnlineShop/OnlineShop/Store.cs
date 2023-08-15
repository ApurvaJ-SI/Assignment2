using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OnlineShop
{
    internal class Store
    {
        List<Product> products;

        public Store()
        {
            products = new List<Product>();
        }

        public void AddProducts(Product product)
        {
           
            products.Add(product);
            
        }

        public void DisplayListOfProducts()
        {
            foreach(Product product in products)
            {
                Console.WriteLine($"Name = {product.Name} Price = {product.Price} Quantity = {product.Quantity} Category = {product.Category}");
            }
        }

        public void TotalValue()
        {
            
            foreach(Product product in products)
            {
               double total = product.Price * product.Quantity;
                Console.WriteLine(total);
            }
            
        }

    }
}
