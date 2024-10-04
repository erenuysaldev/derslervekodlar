using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_Miras_Inheritance.Sınıflar
{
    internal class Otomobil:Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Tür: {Tur}");   
            Console.WriteLine($"Tür: {Marka}");   
            Console.WriteLine($"Tür: {Model}");   
          
        }




    }
}
