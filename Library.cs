using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Library : IBorrowable
    {
        private List<Book> bookList = new List<Book>();

        public void AddBook(Book book)
        {
            bookList.Add(book);
            Console.WriteLine($"Book'{book.Title}' added to the Library");
        }

        public void DisplayBooks()
        {
            if(bookList.Count == 0)
            {
                Console.WriteLine("No books in the Library");
            }
            else
            {
                foreach(var book in bookList)
                {
                    book.DisplayInfo();
                }
            }
        }
        public void Borrow()
        {
            Console.WriteLine("Borrowing from library directly not allowed!");
        }

        public void Return()
        {
            Console.WriteLine("Returning from library directly not allowed!");
        }
    }
}
