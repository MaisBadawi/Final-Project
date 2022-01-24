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
        public string AgePeriod { get; set; }
        public decimal StartAge { get; set; }
        public decimal EndAge { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
