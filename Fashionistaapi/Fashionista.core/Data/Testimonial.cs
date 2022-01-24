using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Testimonial
    {
        public decimal Id { get; set; }
        public string Texet { get; set; }
        public decimal CustomerId { get; set; }
        public decimal Status { get; set; }

        public virtual User Customer { get; set; }
    }
}
