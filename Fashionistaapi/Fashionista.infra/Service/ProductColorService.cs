using Fashionista.core.Data;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fashionista.infra.Service
{
   public class ProductColorService : IProductColorService
    {
        private readonly IProductColorRepository colorRepository;
        public ProductColorService(IProductColorRepository colorRepository)
        {
            this.colorRepository = colorRepository;
        }

        public bool Delete_Color(int id)
        {
            return colorRepository.Delete_Color(id);
        }

        public List<ProductColor> Getall_Color()
        {
            return colorRepository.Getall_Color();
        }

        public ProductColor Get_Color_By_id(int id)
        {
            return colorRepository.Get_Color_By_id(id);
        }

        public string Insert_Color(ProductColor color)
        {
            return colorRepository.Insert_Color(color);     
        }

        public bool update_Color(ProductColor color)
        {
            return colorRepository.update_Color(color);
        }
    }
}
