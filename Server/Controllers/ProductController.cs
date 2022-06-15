using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Controllers
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

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            try
            {
                var products = await productService.GetProductAsync();
                return Ok(products);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
        {
            try
            {
                var product = await productService.GetProductAsync(productId);
                return Ok(product);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
