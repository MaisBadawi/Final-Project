using System;
using System.Collections.Generic;

#nullable disable

namespace Fashionista.core.Data
{
    public partial class Frole
    {
        public Frole()
        {
            Users = new HashSet<User>();
        }

        public decimal Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
