using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class ProductColor
    {
        public ProductColor()
        {
            Properties = new HashSet<Property>();
        }

        public decimal Id { get; set; }
        public string COLOR_PRODUCT { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
