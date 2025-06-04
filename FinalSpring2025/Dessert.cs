using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSpring2025
{
    internal class Dessert
    {
        public Dessert(string? name, double price, string? category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public int DessertId { get; set; }
        
        public string Name { get; set; }

        public double Price { get; set; }

        public string Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
