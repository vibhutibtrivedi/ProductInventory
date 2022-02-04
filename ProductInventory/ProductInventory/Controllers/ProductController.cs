using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductInventory.Models;
using ProductInventory.Services.ProductService;
using ProductInventory.Dtos.Product;

namespace ProductInventory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController :ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController( IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetProductdto>>>> Get()
        {
            return Ok( await _productService.GetProducts());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetProductdto>>> GetSingle(int id) 
        {
            return Ok(await _productService.GetProductById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetProductdto>>> AddProduct(AddProductdto NewProduct)
        {
            
            return Ok(await _productService.AddProduct(NewProduct));
        }
        
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<GetProductdto>>> UpdateProduct(UpdateProductdto updateProduct)
        {
            return Ok(await _productService.UpdateProduct(updateProduct));
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetProductdto>>>> Delete(int id)
        {
            return Ok(await _productService.DeleteProduct(id));
        }
    }
}
