using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //inheriting from DbContext
    public class BookstoreDBContext : DbContext
    {
        //making constructor
        //inheriting from base options
        public BookstoreDBContext (DbContextOptions<BookstoreDBContext> options) : base (options)
        {

        }

        //context file will return DbSet of type book
        public DbSet<Book> Books { get; set; }
    }
}
