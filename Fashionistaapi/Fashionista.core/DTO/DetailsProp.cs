using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class DetailsProp
    {
        public decimal Id { get; set; }

        public string Name { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int AvailableQuantity { get; set; }
        public int SoldQuantity { get; set; }
    }
}
