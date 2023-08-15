namespace OnlineShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();


            while (true) { 
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Products");
                Console.WriteLine("2. Display list of products");
                Console.WriteLine("3. Calculate the total value of products");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");



                int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the name of Product: ");
                            string prodname = Convert.ToString(Console.ReadLine());
                            Console.Write("Price of the product: ");
                            double prodprice = double.Parse(Console.ReadLine());
                            Console.Write("Quantity of the product: ");
                            int prodquantity = int.Parse(Console.ReadLine());
                            Console.Write("Category of the product: ");
                            string prodcategory = Convert.ToString(Console.ReadLine());

                            Product newProduct = new Product(prodname, prodprice, prodquantity, prodcategory);

                            store.AddProducts(newProduct);
                            Console.WriteLine("Products added successfully");
                            break;
                        case 2:
                            store.DisplayListOfProducts();
                            break;
                        case 3:
                            store.TotalValue();
                            break;
                        case 4:
                            Console.WriteLine("Exiting the program");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
            }
        }
    }
}