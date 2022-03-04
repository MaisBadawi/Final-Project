﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
   public class GetPropertyDto
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }

        public string Color { get; set; }
        public string Size { get; set; }
        public decimal EUR_SIZE { get; set; }
        public decimal UK_SIZE { get; set; }

        public string SkinColor { get; set; }
        public decimal Quantity { get; set; }
       


    }
}
