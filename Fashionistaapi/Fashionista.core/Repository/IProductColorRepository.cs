using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
    public interface IProductColorRepository
    {
        public string Insert_Color(ProductColor color);
        public bool Delete_Color(int id);
        public bool update_Color(ProductColor color);
        public List<ProductColor> Getall_Color();
        public ProductColor Get_Color_By_id(int id);
        
    }
}
