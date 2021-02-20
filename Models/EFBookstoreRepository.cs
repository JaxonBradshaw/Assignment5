using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //uses bookstore repository
    public class EFBookstoreRepository : IBookstoreRepository
    {
        private BookstoreDBContext _context;

        //constructor
        public EFBookstoreRepository (BookstoreDBContext context)
        {
            _context = context;
        }
        //Books will always be set to whatever is in _context.Books
        public IQueryable<Book> Books => _context.Books;
    }
}
