using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Message
    {
        public decimal ID { get; set; }
        public decimal CUSTOMER_ID { get; set; }
        public string MESSG { get; set; }
        public string RECIVER { get; set; }
        public decimal STATUS { get; set; }

        public virtual User Customer { get; set; }
    }
}
