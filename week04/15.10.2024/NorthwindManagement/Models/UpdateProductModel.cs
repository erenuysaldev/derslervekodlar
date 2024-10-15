using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


    namespace NorthwindManagement.Models
    {
        internal class UpdateProductModel
        {
            public int Id { get; set; } // Product ID
            public int CategoryId { get; set; } // Category ID
            public string Name { get; set; } // Product Name
            public decimal Price { get; set; } // Product Price
            public int Stock { get; set; } // Product Stock
        }
    }
