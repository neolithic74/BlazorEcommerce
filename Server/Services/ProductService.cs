using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services
{
    public class ProductService
    {
        private readonly DataContext context;

        public ProductService(DataContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductAsync()
        {
            var response = new ServiceResponse<List<Product>>();
            var product = await context.Products.ToListAsync();
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

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
            var response = new ServiceResponse<Product>()
            {
                Data = await context.Products.FindAsync(productId)
            };

            return response;
        }
    }
}
