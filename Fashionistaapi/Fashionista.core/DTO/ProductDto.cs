using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class ProductDto
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime DateOfAdd { get; set; }
        public string Image { get; set; }


    }
}
