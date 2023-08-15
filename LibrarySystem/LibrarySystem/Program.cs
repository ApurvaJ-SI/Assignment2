using System.Runtime.Intrinsics.X86;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Display Book List");
                Console.WriteLine("3. Search Books by Title");
                Console.WriteLine("4. Search Books by Author");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter Quantity Available: ");
                        int quantityAvailable = int.Parse(Console.ReadLine());

                        Book book = new Book(title, author, genre, quantityAvailable);

                        library.AddBook(book);
                        Console.WriteLine("Book added to library.\n");
                        break;

                    case 2:
                        library.DisplayBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book to Search: ");
                        string searchTitle = Console.ReadLine();
                        List<Book> titleResults = library.SearchBooksByTitle(searchTitle);
                        DisplaySearchResults(titleResults);
                        break;

                    case 4:
                        Console.Write("Enter Author to Search: ");
                        string searchAuthor = Console.ReadLine();
                        List<Book> authorResults = library.SearchBooksByAuthor(searchAuthor);
                        DisplaySearchResults(authorResults);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.\n");
                        break;
                }
            }
        }
        public static void DisplaySearchResults(List<Book> results)
        {
            if (results.Count == 0)
            {
                Console.WriteLine("No matching books found.\n");
            }
            else
            {
                Console.WriteLine("Search Results:");
                foreach (var book in results)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Quantity Available: {book.Quantity}");
                }
                Console.WriteLine();
            }
        }

    }
}




   