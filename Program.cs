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
            Book book = null;
            char c;
            do
            {
                Console.WriteLine("Enter the choice\n1.Add Books\n2.Borrow Book\n3.Return Book\n4.Display Books\n5.Exit!");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Title (Drama/Adventure/Romance): ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter Author: ");
                        string auth = Console.ReadLine();
                        Console.WriteLine("Enter ISBN (International Standard Book Number): ");
                        string isbn = Console.ReadLine();

                        book = new Book { Title = title, author = auth, ISBN = isbn };
                        library.AddBook(book);
                        break;

                    case 2:
                        Console.WriteLine("\nBorrow 'Drama' :");
                        book.Borrow();
                        break;

                    case 3:
                        Console.WriteLine("\nReturning 'Drama' :");
                        book.Return();
                        break;

                    case 4:
                        Console.WriteLine("\nDisplaying Library Books Again");
                        library.DisplayBooks();
                        break;
                    case 5:
                        Console.WriteLine("Exited!");
                        return;
                    default:
                        Console.WriteLine("Enter valid choice:");
                        break;
                }
                Console.WriteLine("Enter Y/y to start again or other key to exit!");
                c = char.Parse(Console.ReadLine());
            } while (c == 'Y' || c == 'y');
            Console.WriteLine("Thank you!");
            
        }
    }
}
