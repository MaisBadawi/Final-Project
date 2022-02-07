using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class OrderU { 
        public decimal TotalPrice { get; set; }
        public decimal OrderId { get; set; }
        public string DeliveryName { get; set; }
        public DateTime Date { get; set; }
    }
}
