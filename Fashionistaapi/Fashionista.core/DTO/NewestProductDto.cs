using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
   public class NewestProductDto
    {
        public decimal ID { get; set; }
        public string Name { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string Category { get; set; }
      
       
    }
}
