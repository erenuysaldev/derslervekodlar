using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_Interfaces.Eshop
{
    internal class Category : IBase
    {
       

        public string Description { get; set; }
        public bool IsShowMenu { get; set; }
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
