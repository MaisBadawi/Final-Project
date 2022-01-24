using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Repository;
using Fashionista.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.infra.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productService;

        public ProductService(IProductRepository productService)
        {
            this.productService = productService;
        }
        public string Insert_Product(Product product)
        {
            return productService.Insert_Product(product);
        }

        public bool Delete_Product(int id)
        {
            return productService.Delete_Product(id);
        }

        public bool Update_Product(Product product)
        { return productService.Update_Product(product); }

        public List<Product> GetAll_Product()
        { return productService.GetAll_Product(); }

        public Product GetProduct_ID(int id)
        { return productService.GetProduct_ID(id); }

        public List<GetProductByInfo> GetProduct_Category(PersonInfoDto product)
        {
            return productService.GetProduct_Category(product);        }

        public List<GetProductByInfo> GetProduct_OrderDes(PersonInfoDto product)
        {
            return productService.GetProduct_OrderDes(product);
        }

        public List<GetProductByInfo> GetProduct_OrderAsc(PersonInfoDto product)
        {
            return productService.GetProduct_OrderAsc(product);
        }

        public List<GetProductByInfo> GetLatest_Product(PersonInfoDto product)
        {
            return productService.GetLatest_Product(product);
        }

        public List<GetProductByInfo> GetProduct_Offer(PersonInfoDto product)
        {
            return productService.GetProduct_Offer(product);        }
        }
}
