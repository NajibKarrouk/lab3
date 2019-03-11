using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboration3.Models
{
    public class BookDetail
    {
        // Constructor
        public BookDetail() { }

        // Publika egenskaper
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Usr_Id { get; set; }
    }
}
