using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Message
    {
        public decimal Id { get; set; }
        public decimal CustomerId { get; set; }
        public string Messg { get; set; }
        public string Reciver { get; set; }

        public virtual User Customer { get; set; }
    }
}
