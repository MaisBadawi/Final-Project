using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class StandaredSize
    {
        public StandaredSize()
        {
            Properties = new HashSet<Property>();
        }

        public decimal ID { get; set; }
        public decimal SIZE_UK { get; set; }
        public decimal SIZE_EUR { get; set; }
        public string SIZE_GENERAL { get; set; }
        public decimal MAX_WIEGHT { get; set; }
        public decimal MIN_WIEGHT { get; set; }
        public decimal MAX_HIGHE { get; set; }
        public decimal MIN_HIGHE { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
