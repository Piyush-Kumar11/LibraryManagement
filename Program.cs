using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library!");
            Library library = new Library();

            Book book1 = new Book { Title = "Drama", author = "xyz", ISBN = "156ab" };
            library.AddBook(book1);
            library.AddBook(new Book { Title = "Adventure", author = "abc", ISBN = "15kn" });
            library.AddBook(new Book { Title = "Romance", author = "ikl", ISBN = "45ko" });

            Console.WriteLine("\nDisplaying Library Books");
            library.DisplayBooks();

            Console.WriteLine("\nBorrow 'Drama' :");
            book1.Borrow();
            Console.WriteLine("\nBorrow 'Drama' Again:");
            book1.Borrow();
            Console.WriteLine("\nReturning 'Drama' :");
            book1.Return();

            Console.WriteLine("\nDisplaying Library Books Again");
            library.DisplayBooks();
        }
    }
}
