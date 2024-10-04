using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson18_Miras_Inheritance.Eshop
{
    internal class Brand
    {
        public string LogoUrl { get; set; }
        public  string Description { get; set; }
        public string Country { get; set; }
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public bool IsActive { get; internal set; }
        public DateTime CreatedDate { get; internal set; }
    }
}
