using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Product
    {
        public Product()
        {
            Properties = new HashSet<Property>();
            Reviews = new HashSet<Review>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string IMAGE_PATH { get; set; }
        public decimal? OFFER_ID { get; set; }
        public decimal CategoryId { get; set; }
        public DateTime Dateofadd { get; set; }

        public virtual Category Category { get; set; }
        public virtual Offer Offer { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
