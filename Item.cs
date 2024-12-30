using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    abstract class Item
    {
        [Required(ErrorMessage ="Title is mandatory")]
        public string Title {  get; set; }
        public abstract void DisplayInfo();
    }
}
