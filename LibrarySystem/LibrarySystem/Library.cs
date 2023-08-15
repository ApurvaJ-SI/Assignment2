using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine($"Title:{book.Title}, Author:{book.Author}, Genre:{book.Genre}, Quantity:{book.Quantity}");
            }
            Console.WriteLine();
        }

        public List<Book> SearchBooksByTitle(string title)
        {
            return books.Where(book => book.Title.ToLower().Contains(title.ToLower())).ToList();
        }

        public List<Book>SearchBooksByAuthor(string author)
        {
            return books.Where(book => book.Author.ToLower().Contains(author.ToLower())).ToList();
        }
    }
}
