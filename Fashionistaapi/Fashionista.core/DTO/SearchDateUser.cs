using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
    public class SearchDateUser
    {
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }
        public int CUST_ID { get; set; }
    }
}
