﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiniflarMethodlar.Members
{
    internal class Role
    {
        public int Id   { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate  { get; set; }  = DateTime.Now;

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Id}");
            Console.WriteLine($"Description: {Id}");
            Console.WriteLine($"CreatedDate: {Id}");
        }
    }
}
