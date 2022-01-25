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

        public decimal Id { get; set; }
        public decimal Quantite { get; set; }
        public decimal ColorId { get; set; }
        public decimal SizeId { get; set; }
        public decimal ProductId { get; set; }
        public decimal SkinId { get; set; }
        public decimal AgeId { get; set; }

        public virtual Age Age { get; set; }
        public virtual ProductColor Color { get; set; }
        public virtual Product Product { get; set; }
        public virtual StandaredSize Size { get; set; }
        public virtual Skin Skin { get; set; }
        public virtual ICollection<UserOrder> UserOrders { get; set; }
    }
}
