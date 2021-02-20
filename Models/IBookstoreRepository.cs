using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    //making interface "template" to be inherited from in other places
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
