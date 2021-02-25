using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        //stuff Hilton said to not worry about haha
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookstoreDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDBContext>();

            //if there are pending migrations migrate them
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //if there's nothing in the database do this
            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {
                        Title = "Les Miserables",
                        AuthFirst = "Victor",
                        AuthLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95

                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthFirst = "Doris",
                        AuthLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageCount = 944,
                        Price = 14.58

                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthFirst = "Alice",
                        AuthLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageCount = 832,
                        Price = 21.54

                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthFirst = "Ronald",
                        AuthLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageCount = 864,
                        Price = 11.61

                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthFirst = "Laura",
                        AuthLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        PageCount = 528,
                        Price = 13.33

                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthFirst = "Michael",
                        AuthLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        PageCount = 288,
                        Price = 15.95

                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthFirst = "Cal",
                        AuthLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageCount = 304,
                        Price = 14.99

                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthFirst = "Michael",
                        AuthLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageCount = 240,
                        Price = 21.66

                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthFirst = "Richard",
                        AuthLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        PageCount = 400,
                        Price = 29.16

                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthFirst = "John",
                        AuthLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        PageCount = 642,
                        Price = 15.03

                    },

                    new Book
                    {
                        Title = "Elantris",
                        AuthFirst = "Brandon",
                        AuthLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-1501259203",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        PageCount = 592,
                        Price = 24.99

                    },

                    new Book
                    {
                        Title = "Mistborn",
                        AuthFirst = "Brandon",
                        AuthLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765350381",
                        Classification = "Fiction",
                        Category = "High Fantasy",
                        PageCount = 541,
                        Price = 24.44

                    },

                    new Book
                    {
                        Title = "The Way of Kings",
                        AuthFirst = "Brandon",
                        AuthLast = "Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Classification = "Fiction",
                        Category = "High Fantasy",
                        PageCount = 1008,
                        Price = 23.64

                    }


                );

                //writing to database
                context.SaveChanges();
            }
        }
    }
}
