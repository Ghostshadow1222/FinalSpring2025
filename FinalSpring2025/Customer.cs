using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSpring2025
{
    internal class Customer
    {
        public Customer(string? name, string? email, DateTime dateOfBirth)
        {
            Name = name;
            Email = email;
            DateOfBirth = dateOfBirth;
        }

        // Propeties that have been automatically implemented, making it easier to type up

        public int CustomerId { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
