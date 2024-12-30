using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            try
            {
                bookList.Add(book);
                var context = new ValidationContext(book);
                var results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(book, context, results, true);

                if (isValid)
                {
                    Console.WriteLine($"Book'{book.Title}' added to the Library");
                }
                else
                {
                    Console.WriteLine("Data validation failed");
                    foreach (var i in results)
                    {
                        Console.WriteLine("Error: " + i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message );
            } 
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
