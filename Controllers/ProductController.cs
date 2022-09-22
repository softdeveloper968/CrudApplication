using CrudApplication.Service;
using CrudApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _productService.GetProducts());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ProductViewModel product)
        {
            try
            {
                return Ok(await _productService.AddProduct(product));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(ProductViewModel product)
        {
            try
            {
                return Ok(await _productService.UpdateProduct(product));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int productId)
        {
            try
            {
                return Ok(await _productService.DeleteProduct(productId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
