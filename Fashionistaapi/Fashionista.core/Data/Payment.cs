using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Payment
    {
        public decimal Id { get; set; }
        public string Visa_Number { get; set; }
        public string Cvv { get; set; }
        public DateTime Experd_Date { get; set; }
        public decimal Balanc { get; set; }
        public decimal? User_Id { get; set; }

        public virtual User User { get; set; }
    }
}
