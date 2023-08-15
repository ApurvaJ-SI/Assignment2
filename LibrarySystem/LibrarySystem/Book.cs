using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        string title;
        string author;
        string genre;
        int quantity;

        public Book(string title, string author, string genre, int quantity)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.quantity = quantity;

        }

        public Book() { }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        { get { return author; }
           set{ author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}
