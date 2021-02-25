using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Book
    {
        //setting BookID as the key
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthFirst { get; set; }
        [Required]
        public string AuthLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        //regex to validate ISBN
        [RegularExpression(@"^[0-9]{3}-[0-9]{10}$", ErrorMessage = "Invalid form for ISBN")]
        public string ISBN { get; set; }
        //Classicfication/Category
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public double Price { get; set; }
        public int PageCount { get; set; }
    }
}
