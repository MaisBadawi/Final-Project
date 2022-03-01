using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Data
{
  public  class home
    {
        public int ID { get; set; }
        public int user_id { get; set; }
        public string carousal1 { get; set; }
        public string carousal2 { get; set; }
        public string carousal3 { get; set; }
        public string carousal4 { get; set; }
        public string carousal5 { get; set; }
        public string carousal6 { get; set; }
        public string carousal7 { get; set; }
        public string carousal8 { get; set; }
        public string carousal9 { get; set; }
        public string carousal10 { get; set; }
        public string carousal11 { get; set; }
        public string carousal12 { get; set; }

        public string About_para1 { get; set; }
        public string About_para2 { get; set; }
        public string service_para1 { get; set; }
        public string service_para2 { get; set; }
        public string service_para3 { get; set; }
        public string service_photo { get; set; }
        public string contact_image { get; set; }
        public string about1 { get; set; }
        public string about2 { get; set; }
        public string about3 { get; set; }
        public string about4 { get; set; }
        public string about5 { get; set; }
        public string about6 { get; set; }

        public virtual User Customer { get; set; }
    }
}
