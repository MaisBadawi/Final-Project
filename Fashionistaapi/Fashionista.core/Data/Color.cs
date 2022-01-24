using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Color
    {
        public Color()
        {
            Properties = new HashSet<Property>();
        }

        public decimal Id { get; set; }
        public string ColorProduct { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
