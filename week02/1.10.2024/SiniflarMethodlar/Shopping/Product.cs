using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarMethodlar.Shopping
{
    internal class Product
    {
        public Product()
        {
            
        }

        public Product(int ıd, string name) : this(ıd)
        {
            Name = name;
        }

        public Product(int ıd)
        {
            Id = ıd;
        }

        public Product(int ıd, string name, string description) : this(ıd, name)
        {
            Description = description;
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } = 1;
    }
}
