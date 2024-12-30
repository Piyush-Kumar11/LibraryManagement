using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class Book:Item,IBorrowable
    {
        [Required(ErrorMessage ="Author name is mandatory")]
        [StringLength(25,ErrorMessage ="Author name should be between 4 to 25 characters",MinimumLength =4)]
        public string author { get; set; }

        // International Standard Book Number -ISBN (a unique 13 digit number for every books)
        [Required(ErrorMessage ="ISBN is mandatory")]
        [StringLength(13, ErrorMessage = "ISBN must be exactly 13 digits."),MinLength(13)]
        public string isbn { get; set; }

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
