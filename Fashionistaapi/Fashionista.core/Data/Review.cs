using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Review
    {
        public decimal Id { get; set; }
        public string Comments { get; set; }
        public decimal CustomerId { get; set; }
        public decimal ProductId { get; set; }
        public decimal Status { get; set; }
        public decimal Rating { get; set; }

        public virtual User Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
