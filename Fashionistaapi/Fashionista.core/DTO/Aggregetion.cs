using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.DTO
{
   public class Aggregetion
    {
        public int NumOfOrder;
        public int SumOrders { get; set; }
        public int NumEmp { get; set; }
        public int NumUser { get; set; }
        public float SumSalary { get; set; }
        public float SumSales { get; set; }
        public float SumSalesDaily { get; set; } 
        public int NumOrderDev { get; set; }
        public int NumOrderDevDaily { get; set; }
        public DateTime dateDatesales { get; set; }

  }
}
