using Fashionista.core.Data;
using Fashionista.core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface IProductService
    {
        public string Insert_Product(Product product);
        public bool Delete_Product(int id);

        public bool Update_Product(Product product);
        public List<ProductDto> GetAll_Product();
        public Product GetProduct_ID(int id);

        public List<GetProductByInfo> GetProduct_Category(PersonInfoDto product);
        public List<GetProductByInfo> GetProduct_OrderDes(PersonInfoDto product);

        public List<GetProductByInfo> GetProduct_OrderAsc(PersonInfoDto product);

        public List<GetProductByInfo> GetLatest_Product(PersonInfoDto product);

        public List<GetProductByInfo> GetProduct_Offer(PersonInfoDto product);

    }
}
