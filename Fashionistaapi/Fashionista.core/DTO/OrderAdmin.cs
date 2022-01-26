using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class OrderAdmin
    {
        public Decimal orderId { get; set; }
        public string CustomerName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public float TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public int DeliveryName { get; set; }
        
    }
}
