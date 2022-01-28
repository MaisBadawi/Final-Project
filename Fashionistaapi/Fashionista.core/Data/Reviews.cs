using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Reviews
    {
        public decimal ID { get; set; }
        public string COMMENTS { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal STATUS { get; set; }
        public decimal RATING { get; set; }

        public virtual User Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
