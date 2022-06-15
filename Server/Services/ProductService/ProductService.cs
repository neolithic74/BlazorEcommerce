using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext context;

        public ProductService(DataContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductAsync()
        {
            var response = new ServiceResponse<List<Product>>()
            {
                Data = await context.Products.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>();
            var product = await context.Products.FindAsync(productId);
            if (product == null)
            {
                response.Success = false;
                response.Messsage = "Sorry, but this product not exist";
            }
            else
            {
                response.Data = product;
            }

            return response;
        }
    }
}
