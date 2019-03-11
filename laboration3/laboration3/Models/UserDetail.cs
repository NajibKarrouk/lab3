using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laboration3.Models
{
    public class UserDetail
    {
        // Constructor
        public UserDetail() { }

        // Publika egenskaper
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
