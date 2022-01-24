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

        public decimal Id { get; set; }
        public decimal SizeUk { get; set; }
        public decimal SizeEur { get; set; }
        public string SizeGeneral { get; set; }
        public decimal MaxWieght { get; set; }
        public decimal MinWieght { get; set; }
        public decimal MaxHighe { get; set; }
        public decimal MinHighe { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}
