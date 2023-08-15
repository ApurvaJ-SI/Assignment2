namespace OnlineCart.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add items to the cart:");
                Console.WriteLine("2. Display items in the cart:");
                Console.WriteLine("3. Calculate total cost:");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Items to be added:");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("Price of the item:");
                        double itemPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Quantity of the item:");
                        int itemQuantity = Convert.ToInt32(Console.ReadLine());

                        Item newItem = new Item(itemName, itemPrice, itemQuantity);

                        cart.AddItems(newItem);
                        Console.WriteLine("Item added to the cart:");
                        break;
                    case 2:
                        cart.DisplayListOfItem();
                        break;
                    case 3:
                        cart.CalculateAmount();
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