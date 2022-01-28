using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Property
    {
        public Property()
        {
            UserOrders = new HashSet<UserOrder>();
        }

        public decimal ID { get; set; }
        public decimal QUANTITE { get; set; }
        public decimal COLOR_ID { get; set; }
        public decimal SIZE_ID { get; set; }
        public decimal PRODUCT_ID { get; set; }
        public decimal SKIN_ID { get; set; }
        public decimal AGE_ID { get; set; }
        public virtual Age Age { get; set; }
        public virtual ProductColor Color { get; set; }
        public virtual Product Product { get; set; }
        public virtual StandaredSize Size { get; set; }
        public virtual Skin Skin { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
