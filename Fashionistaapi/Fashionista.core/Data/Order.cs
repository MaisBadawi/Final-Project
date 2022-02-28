using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Order
    {
        public Order()
        {
            UserOrders = new HashSet<UserOrder>();
        }

        public decimal Id { get; set; }
        public DateTime Dateoforder { get; set; }
        public decimal? Status { get; set; }
        public decimal? Delivery_Id { get; set; }
        public string LX { get; set; }

        public string LY { get; set; }

    public virtual Delivery Delivery { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
