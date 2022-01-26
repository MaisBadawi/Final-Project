using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class OrderU { 
        public decimal TotalPrice { get; set; }
        public decimal orderId { get; set; }
        public decimal DeliveryName { get; set; }
        public DateTime Date { get; set; }
    }
}
