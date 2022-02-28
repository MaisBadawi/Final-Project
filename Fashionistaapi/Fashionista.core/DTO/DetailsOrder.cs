using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class DetailsOrder
    {
        public int ID { get; set; }
        public int IdPro { get; set; }
        public string Name { get; set; }
        public string ProductImage { get; set; }
        public string GeneralSize { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int EURSIZE { get; set; }
        public int UK { get; set; }
        public float Price { get; set; }

    }
}
