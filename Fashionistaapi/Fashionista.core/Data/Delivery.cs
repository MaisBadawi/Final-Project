using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Delivery
    {
        public Delivery()
        {
            Orders = new HashSet<Order>();
        }

        public decimal Id { get; set; }
        public decimal Delivery_Id { get; set; }
        public string Xlit { get; set; }
        public string Ylit { get; set; }
        public decimal Status { get; set; }

        public virtual User DeliveryNavigation { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
