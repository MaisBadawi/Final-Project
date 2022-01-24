using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
   public class GetPropertyDto
    {
        public string Name { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }

        public string Color { get; set; }
        public string GeneralSize { get; set; }
        public decimal EUR_SIZE { get; set; }
        public decimal UK_SIZE { get; set; }

        public string SkinColor { get; set; }
        public decimal Quantity { get; set; }
       


    }
}
