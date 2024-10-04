using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarMethodlar.Shopping
{
    internal class Category
    {
        public Category(string name)
        {
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public required string note { get; set; }            

    }
}
