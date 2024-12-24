﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity.Concrete
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }//Navigation p.
        public int CategoryId { get; set; }
        public Category Category { get; set; }//Navigation p
    }
}