using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //adding virtual to methods so that we can override members
        public virtual void AddItem(Book book, int qty)
        {
            //building new cartline
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            //adding new cartline if there's nothing in it
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            //otherwise updating quantity
            else
            {
                line.Quantity += qty;
            }

        }

        //method for removal
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //method for clearing
        public virtual void Clear() => Lines.Clear();

        //method for computing the total sum
        public double ComputeTotalSum() => Lines.Sum(e => e.Book.Price * e.Quantity);


        //creating CartLine class
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}

