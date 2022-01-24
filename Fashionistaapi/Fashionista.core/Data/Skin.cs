using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Skin
    {
        public Skin()
        {
            Properties = new HashSet<Property>();
        }

        public decimal Id { get; set; }
        public string ColorSkin { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
