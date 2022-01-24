using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Age
    {
        public Age()
        {
            Properties = new HashSet<Property>();
        }

        public decimal Id { get; set; }
        public string AGE_PERIOD { get; set; }
        public decimal START_AGE { get; set; }
        public decimal END_AGE { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
