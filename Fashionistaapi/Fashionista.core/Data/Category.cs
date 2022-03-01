using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Image_Path { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
