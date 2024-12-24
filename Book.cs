using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book:Item,IBorrowable
    {
        public string author { get; set; }
        public string isbn;

        public string ISBN
        {
            get => isbn;
            set => isbn = value;
        }

        public bool IsBorrowed { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title},Author: {author},ISBN: {ISBN}");
        }

        public void Borrow()
        {
            if(IsBorrowed)
            {
                Console.WriteLine("The Book is already Borrowed");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine("The Book has been Borrowed");
            }
        }
        public void Return()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                Console.WriteLine("The Book has been returned!");
            }
            else
            {
                Console.WriteLine("The Book was not returned");
            }
        }
    }
}
