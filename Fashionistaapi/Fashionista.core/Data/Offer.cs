using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Offer
    {
        public Offer()
        {
            Products = new HashSet<Product>();
        }

        public decimal Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
