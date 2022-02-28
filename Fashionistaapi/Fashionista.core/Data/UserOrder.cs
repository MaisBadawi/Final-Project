using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class UserOrder
    {
        public decimal Id { get; set; }
        public decimal OrderId { get; set; }
        public decimal CustId { get; set; }
        public decimal Pro_Id { get; set; }//check
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual User Cust { get; set; }
        public virtual Order Order { get; set; }
        public virtual Property Pro { get; set; }
    }
}
