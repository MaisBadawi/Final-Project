using Fashionista.core.Data;
using Fashionista.core.DTO;
using Fashionista.core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fashionista.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
           this.productService = productService;
        }

        [HttpPost]
        [Route("InsertNewProduct")]
        public string Insert_Product([FromBody]Product product)
        { return productService.Insert_Product(product); }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public bool Delete_Product(int id)
        { return productService.Delete_Product(id); }

        [HttpPut]
        [Route("UpdateProduct")]
        public bool Update_Product([FromBody] Product product)
        { return productService.Update_Product(product); }

        [HttpGet]
        [Route("AllProduct")]
        public List<Product> GetAll_Product()
        { return productService.GetAll_Product(); }

        [HttpGet]
        [Route("AllProductById/{id}")]
        public Product GetProduct_ID(int id)
        { return productService.GetProduct_ID(id); }

        [HttpPost]
        [Route("AllProductForCust")]
        public List<GetProductByInfo> GetProduct_Category([FromBody] PersonInfoDto product)
        { return productService.GetProduct_Category(product); }


        [HttpPost]
        [Route("AllProductDec")]
        public List<GetProductByInfo> GetProduct_OrderDes([FromBody] PersonInfoDto product)
        { return productService.GetProduct_OrderDes(product); }

        [HttpPost]
        [Route("AllProductAsc")]
        public List<GetProductByInfo> GetProduct_OrderAsc([FromBody] PersonInfoDto product)
        { return productService.GetProduct_OrderAsc(product); }

        [HttpPost]
        [Route("GetLatestProduct")]
        public List<GetProductByInfo> GetLatest_Product([FromBody] PersonInfoDto product)
        { return productService.GetLatest_Product(product); }

    }
}
