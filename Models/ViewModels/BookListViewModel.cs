using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models.ViewModels
{
    public class BookListViewModel
    {
        //model going to the view now has info on list of books
        public IEnumerable<Book> Books { get; set; }
        //and info on page number stuff
        public PagingInfo PagingInfo { get; set; }
    }
}
